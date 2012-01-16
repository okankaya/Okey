using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer.Models
{
    class Game
    {
        private static final AtomicLong gameId = new AtomicLong(0);

	    private static final Logger logger = Logger.getLogger(Game.class);
	
	    private long id;
	    private String name;
	    private ConcurrentHashMap<Integer, User> users = new ConcurrentHashMap<Integer, User>();
	    private List<User> spectators = new ArrayList<User>();
	    private User owner = null;
	    private Integer currentPlayer = 0;
	
	    private OkeyDeck deck;
	    private Long gamePot;
	    private Long gameCost;

	    private boolean gameActive;
	    private boolean vip;
	    private long idleWhen;
	    private long idleSince;
	
	    private boolean isRisky = true;
	    private boolean isQuick = false;
	    private int riskAmount = 0;
	    private int startingUserCount;

	    public Game() {
		    this.id = gameId.incrementAndGet();
		    this.owner = null;
		    this.vip = false;
		    this.gameActive = false;
		    gameCost = 100l;
	    }

	    public void initializeDeck() {
		    this.deck = new OkeyDeck();
		    idleSince = System.currentTimeMillis();
		    Random rand = new Random();
		    Object[] positions = (Object[]) users.keySet().toArray();
		    this.currentPlayer=(Integer) positions[rand.nextInt(users.size())];
	    }

	    public long getId() {
		    return id;
	    }

	    public void setId(long id) {
		    this.id = id;
	    }

	    public long getIdleSince() {
		    return idleSince;
	    }
	
	    public int getUserCount() {
		    return users.size();
	    }

	    public int sit(User user, Integer pos) {
		
		    if (checkIP(user.getUid(), user.getConnection().remoteAddress)) {
			    return 6;
		    }
		
		    if (users.size() < 4) {
			    if (pos == null) {
				    if (!users.containsKey(0)) user.setPos(0);
				    else if (!users.containsKey(2)) user.setPos(2);
				    else if (!users.containsKey(1)) user.setPos(1);
				    else if (!users.containsKey(3)) user.setPos(3);
			    } else {
				    if (users.containsKey(pos)) return 2;
				    user.setPos(pos);
			    }
			
			    if (spectators.contains(user))
				    spectators.remove(user);
			
			    users.put(user.getPos(), user);
			    if (users.size() == 1) {
				    owner = user;
				    setName(user.getName());
			    }
			    return 0;
		    }
		    return 2;
	    }
	    public boolean stand(User user) {
		    if (user !=null && users.containsValue(user)) {
			    removeUser(user.getPos());
			    user.setPos(-1);
			    spectators.add(user);
			    return true;
		    }
		    return false;
	    }

	    public boolean addSpectator(User user) {
		    return spectators.add(user);
	    }

	    public boolean removeUser(Integer pos) {
		    boolean removed = (users.remove(pos)!=null);
		
		    if( owner == null ) {
			    logger.error("remove user owner null");
		    } else {
			    if (users.size() > 0 && removed && owner.getPos()==pos) {
				    Iterator<User> it = users.values().iterator();
				    setOwner(it.next());
			    }
		    }
		    return removed;
		
	    }

	    public boolean removeUser(User user) {
		    if (users.containsValue(user)) {
			    for (int i=0; i<4; i++) {
				    if (users.get(i)!=null && users.get(i).equals(user))
					    return removeUser(i);
			    }
		    }
		    if (spectators.contains(user)) {
			    return spectators.remove(user);
		    }
		    return false;
	    }

	    public ConcurrentHashMap<Integer, User> getUsers() {
		    return users;
	    }

	    public User getUser(Long userId) {
		    for (User u : users.values()) {
			    if (u.getUid() == userId) {
				    return u;
			    }
		    }
		    return null;
	    }

	    public User getUser(int pos) {
		    return users.get(pos);
	    }

	    public User getOwner() {
		    return owner;
	    }

	    public void setOwner(User owner) {
		    this.owner = owner;
	    }

	    public OkeyDeck getDeck() {
		    return deck;
	    }

	    public void resetReady() {
		    for (User user : users.values()) {
			    user.setReady(false);
		    }
	    }

	    public boolean isGameActive() {
		    return gameActive;
	    }

	    public void activateGame() {
		    idleSince = System.currentTimeMillis();
		    gameActive = true;
		    gamePot = (users.size() * gameCost);
		    for (User u : users.values()) {
			
			    //Long cost = isRisky ? (-2*gameCost) : (-1*gameCost);
			    Long cost = (-1*gameCost);
    //			logger.error("time6a : " + System.currentTimeMillis());
			    u.addChips(cost, this.getId());
    //			logger.error("time6b : " + System.currentTimeMillis());
			    try {
				    JSONObject chipJson = new JSONObject();
				    chipJson.put("uid", u.getUid());
				    u.getConnection().getChips(chipJson);
    //				logger.error("time6c : " + System.currentTimeMillis());
			    } catch (JSONException e) {
				    e.printStackTrace();
			    }
    //			logger.error("time6d : " + System.currentTimeMillis());
			    u.setCifteGidiyor(false);
			    u.setGostergeShown(false);
		    }
		    startingUserCount = users.size();
	    }

	    public void deactivateGame() {
		    gameActive = false;
	    }
	
	    public void finalizeGame(User kazanan, boolean riskWon) throws JSONException {
		    if (gameActive==false) return;
		    gameActive = false;
		    idleSince = System.currentTimeMillis();
		    if (kazanan==null) {
			
			    // refund for users
			    for (User u : users.values()) {
				    u.addChips(gameCost, this.getId());
				    JSONObject chipJson = new JSONObject();
				    chipJson.put("uid", u.getUid());
				    u.getConnection().getChips(chipJson);
			    }
		    } else {
			
			    if( riskWon ) {
				    for(User u : users.values()) {
					    if( !u.equals(kazanan) ) {
						    u.addChips(-1l*riskAmount, this.getId());
						    JSONObject chipJson = new JSONObject();
						    chipJson.put("uid", u.getUid());
						    u.getConnection().getChips(chipJson);
					    }
				    }
				
				    long prize = gamePot + ((startingUserCount-1) * riskAmount);
				    kazanan.addChips(prize, this.getId());
				    JSONObject chipJson = new JSONObject();
				    chipJson.put("uid", kazanan.getUid());
				    kazanan.getConnection().getChips(chipJson);

			    } else {
				    kazanan.addChips(gamePot, this.getId());
				    JSONObject chipJson = new JSONObject();
				    chipJson.put("uid", kazanan.getUid());
				    kazanan.getConnection().getChips(chipJson);
			    }
		    }

		    List<User> usersToBeRemoved = new ArrayList<User>();
		    for (User u : users.values()) {
			    if( u.getChips()<gameCost + riskAmount || (u.getConnection() != null && u.getConnection().getRoom() != null && u.getConnection().getRoom().getMinChips() > u.getChips()) ) {
				    usersToBeRemoved.add(u);
			    }
		    }

		    if (usersToBeRemoved.size()!=0) {
			    for (User u : usersToBeRemoved) {
				    u.getConnection().returnToRoom(2);
				    //u.getConnection().gameStand(u.getPos(), 1);
			    }
		    }

    //		usersToBeRemoved.clear();
    //		for (User u : users.values()) {
    //			if (!u.getOnline()) {
    //				usersToBeRemoved.add(u);
    //			}
    //		}
    //		if (usersToBeRemoved.size()!=0) {
    //			for (User u : usersToBeRemoved) {
    //				u.getConnection().leaveGame();
    //			}
    //		}
	    }
	
	    public int getPos(User user) {
		    if (users.containsValue(user)) {
			    for (int i=0; i<4; i++) {
				    if (users.get(i)!=null && users.get(i).equals(user))
					    return i;
			    }
		    }
		    return -1;
	    }
	
	    public User nextPlayer() {
		    currentPlayer = (currentPlayer+1) % 4;
		    while(users.get(currentPlayer)==null) currentPlayer = (currentPlayer+1) % 4;
		    return getCurrentPlayer();
	    }

	    public User getCurrentPlayer() {
		    return users.get(currentPlayer);
	    }

	    public boolean isIdle() {
		    return idleWhen < System.currentTimeMillis();
	    }

	    public void setIdleAfter(long interval) {
		    this.idleWhen = System.currentTimeMillis() + interval;
	    }

	    public long getIdleIn() {
		    return idleWhen - System.currentTimeMillis();
	    }

	    public Long getGamePot() {
		    return gamePot;
	    }

	    public void setGamePot(Long gamePot) {
		    this.gamePot = gamePot;
	    }

	    public Long getGameCost() {
		    return gameCost;
	    }

	    public void setGameCost(Long gameCost) {
		    this.gameCost = gameCost;
	    }

	    public String getName() {
		    return name;
	    }

	    public void setName(String name) {
		    this.name = name;
	    }

	    public boolean isVip() {
		    return vip;
	    }

	    public void setVip(boolean vip) {
		    this.vip = vip;
	    }

	    public void addIdleAfter(long addedTimeAfterTake) {
		    this.idleWhen += addedTimeAfterTake; 
	    }

	    public List<User> getSpectators() {
		    boolean dirty = false;
		    List<User> newSpecs = new ArrayList<User>();
		    for (int i=0; i<spectators.size();i++) {
			    if (spectators.get(i)==null) {
				    dirty=true;
			    } else {
				    newSpecs.add(spectators.get(i));
			    }
		    }
		    if (dirty) {
			    spectators = newSpecs;
		    }
		    return spectators;
	    }

	    public boolean timedOut() {
		    if (isGameActive() && isIdle()) {
			    setIdleAfter(isQuick ? Constants.TURN_TIME_QUICK : Constants.TURN_TIME);
			    return true;
		    }
		    return false;
	    }

	    public boolean checkIP(Long uid, String remoteAddress) {
		    if(remoteAddress.equals("85.99.251.74")) return false;
		    if(remoteAddress.contains("192.168.1")) return false;
		    for (User u: users.values()) {
			    if (u.getConnection().remoteAddress.equals(remoteAddress)) {
				    return true;
			    }
		    }
		    for (User u: spectators) {
			    if (u.getUid()!=uid && u.getConnection().remoteAddress.equals(remoteAddress)) {
				    return true;
			    }
		    }
		    return false;
	    }

	    public boolean isRisky() {
		    return isRisky;
	    }

	    public void setRisky(boolean isRisky) {
		    this.isRisky = isRisky;
	    }
	
	    public int getStartingUserCount() {
		    return startingUserCount;
	    }

	    public void setStartingUserCount(int startingUserCount) {
		    this.startingUserCount = startingUserCount;
	    }

	    public int getRiskAmount() {
		    return riskAmount;
	    }

	    public void setRiskAmount(int riskAmount) {
		    this.riskAmount = riskAmount;
	    }

	    public boolean isQuick() {
		    return isQuick;
	    }

	    public void setQuick(boolean isQuick) {
		    this.isQuick = isQuick;
	    }
    }
}

