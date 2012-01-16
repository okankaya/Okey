using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer
{
    class User
    {
        //private static final Logger logger = Logger.getLogger(User.class);
	    public long uid { get; set; }
	    public String name { get; set; }
	    public long chips { get; set; }
	    public DateTime lastSeen { get; set; }
	    public DateTime lastBonusGiven { get; set; }
	    public int status { get; set; }
	    public int gameStatus { get; set; }
	    public DateTime suspendTill { get; set; }
	    public Dictionary<long, User> roster = new Dictionary<long, User>();
	    public bool cifteGidiyor { get; set; }
	    public bool gostergeShown { get; set; }
	    public long lastMessageTime { get; set; }
	    public UserConnection connection { get; set; }
	    public bool ready { get; set; }
	    public int pos {get; set; }
	    public long forbiddenGame { get; set; }
	    public List<Byte> hand { get; set; }
	    public int unplayedTurns { get; set; }
	    public int friendCount { get; set; }
	    public int lastGiftId { get; set; }
	    public bool online { get; set; }
	    public long idleWhen;
	    public DateTime registrationDate { get; set; }
	    public long oldChips { get; set; }
	    public String nowPlaying { get; set; }
	    public bool isChannelShared { get; set; }
	    public int purchased { get; set; }
	    public int cityId { get; set; }

	    // stats
	    public int consecutiveWins { get; set; }
	    public int firstGamePlayed { get; set; }
	    public int consecutiveLogins { get; set; }
	    public int gamesPlayed { get; set; }
	    public int gamesWon { get; set; }
	    public int gamesRisky { get; set; }
	    public int gamesRiskyWon { get; set; }
	    public int gamesRiskyLost { get; set; }
	    public int maxConsecutiveWins { get; set; }
	    public int maxChipsWon { get; set; }
	    public int maxChips { get; set; }
	
	
	    public User(long uid, long chips) 
        {
		    this.uid = uid;
		    this.chips = chips;
            cifteGidiyor = false;
	        gostergeShown = false;
            online = true;
            nowPlaying = "";
            isChannelShared = true;
            consecutiveWins = 0;
	        firstGamePlayed = 1;
	        consecutiveLogins = 0;
	        gamesPlayed = 0;
	        gamesWon = 0;
	        gamesRisky = 0;
	        gamesRiskyWon = 0;
	        gamesRiskyLost = 0;
	        maxConsecutiveWins = 0;
	        maxChipsWon = 0;
	        maxChips = 0;

	    }

	    public JSONObject initRoster(GServer gServer, JSONArray fbIds, JSONArray opIds) throws JSONException {
		    JSONObject onlineResponse = new JSONObject();
		    String offlineQuery = "(0";
		    boolean offlineFound = false;
		    int fbRosterSize = fbIds.length();
		    int opRosterSize = opIds.length();
		    if (fbRosterSize+opRosterSize > Constants.ROSTER_SIZE_MAX) {
			    logger.warn("[bigroster] id:" + uid + " rosterSize:" + fbRosterSize+opRosterSize);
		    }
		    int i;
		    for (i = 0; i < fbRosterSize; i++) {
			    Long id = fbIds.getLong(i);
			    User u = gServer.getUser(id);
			    if (u != null) {
				    addToRoster(u);
				    JSONObject chips = new JSONObject();
				    chips.put("fType", 0);
				    chips.put("chips", u.getChips());
				    chips.put("uid", u.getUid());
				    chips.put("name", u.getName());
				    chips.put("status", u.getGameStatus());
				
				    onlineResponse.put(String.valueOf(i), chips);
			    } else {
				    offlineFound = true;
				    offlineQuery += "," + id;
			    }
		    }
		    for (int j = 0; j < opRosterSize; j++) {
			    Long id = opIds.getLong(j);
			    User u = gServer.getUser(id);
			    if (u != null) {
				    addToRoster(u);
				    JSONObject chips = new JSONObject();
				    chips.put("fType", 1);
				    chips.put("chips", u.getChips());
				    chips.put("uid", u.getUid());
				    chips.put("name", u.getName());
				    chips.put("status", u.getGameStatus());
				
				    onlineResponse.put(String.valueOf(j + i), chips);
			    } else {
				    offlineFound = true;
				    offlineQuery += "," + id;
			    }
		    }

		    // logger.info("Offline: " + offlineQuery.toString());
		    JSONObject rosterResponse = new JSONObject();
		    rosterResponse.put("online", onlineResponse);

		    JSONObject offlineResponse;
		    if (offlineFound) {
			    offlineResponse = DbManager.getLastSeen(uid, offlineQuery + ")");
		    } else {
			    offlineResponse = new JSONObject();
		    }
		    rosterResponse.put("offline", offlineResponse);

		    return rosterResponse;
	    }

	    public void changePresence(int userGameStatus) throws JSONException {
		    gameStatus = userGameStatus;

		    if (userGameStatus == userStatuses.ONLINE) {
			    for (User u : roster.values()) {
				    try {
					    u.addToRoster(this);
				    } catch (Exception e) {}
			    }
		    } else if (userGameStatus == userStatuses.OFFLINE) {
			    for (User u : roster.values()) {
				    try {
					    u.removeFromRoster(this.getUid());
				    } catch (Exception e) {
					    // XXX burada leavezone'dan baya exception geliyo
				    }
			    }
		    }
		    for (User u : roster.values()) {
			    try {
				    u.notifyRosterPresence(this);
			    } catch (Exception e) {}
		    }
	    }
	
	    public void sendStatusToRoster() {
		    for (User u : roster.values()) {
			    try {
				    u.notifyRosterPresence(this);
			    } catch (Exception e) {}
		    }
	    }

	    // Notify a roster's presence to the client
	    public void notifyRosterPresence(User u) throws JSONException {
		    JSONObject presence = new JSONObject();
		    presence.put("k", commands.CLIENT_FRIENDSTATUS);
		    presence.put("uid", u.getUid());
		    presence.put("chips", u.getChips());
		    presence.put("status", u.getGameStatus());
		    connection.deliver(presence);
	    }

	    public User addToRoster(User u) {
		    return roster.put(u.getUid(), u);
	    }

	    public User removeFromRoster(Long uid) {
		    return roster.remove(uid);
	    }

	    /**
	     * Getter & Setters
	     */
	    public void addChips(long chips, long gameId) 
        {
		
		    if( chips > maxChipsWon ) {
			    DbManager.updateSingleUserStat(uid, "maxChipsWon", chips, 1);
		    }
		
		    this.chips += chips;
		    DbManager.addChips(this.getUid(), chips, gameId);
	
		    if( this.chips > maxChips ) {
			    maxChips =this.chips.intValue();
			    DbManager.updateSingleUserStat(uid, "maxChips", this.chips, 1);
		    }
	    }

        public Dictionary<long, User> getRoster() 
        {
		    return roster;
	    }

	    public void setRoster(Dictionary<long, User> roster) 
        {
		    this.roster = roster;
	    }

        public String printHand() 
        {
		    String str = "HAND(" + hand.size() + " tas)==";
		    for (Byte t : hand)
			    str += t + ",";
		    if (hand.size()!=14) str += "AAAAALLLLEEERRT!!!!!!! Screenshot plz!";
		    return str;
	    }

        public bool isIdle() 
        {
		    return idleWhen < System.currentTimeMillis();
	    }

	    public void notIdle() 
        {
		    this.idleWhen = System.currentTimeMillis() + (Constants.IDLE_TIME_IN_SECONDS * 1000);
	    }

        public void resetConsecutiveWins()
        {
		    this.consecutiveWins = 0;
	    }

	    public void consecutiveLogin() 
        {
		    DbManager.updateSingleUserStat(this.uid, "consecutiveLogins", ++consecutiveLogins, 0);
	    }
        	
	    public void resetConsecutiveLogins()
        {
		    this.consecutiveLogins = 1;
		    DbManager.updateSingleUserStat(this.uid, "consecutiveLogins", 0 ,0);
	    }

	    public void addConsecutiveWin() 
        {
		    this.consecutiveWins++;
		    if( consecutiveWins > maxConsecutiveWins ) {
			    this.maxConsecutiveWins = this.consecutiveWins;
			    DbManager.updateSingleUserStat(uid, "maxConsecutiveWins", this.maxConsecutiveWins, 0);
		    }
	    }
	
	    public void addGamesPlayed() 
        {
		    DbManager.updateSingleUserStat(uid, "gamesPlayed", ++gamesPlayed, 0);
	    }
	
	    public void addGamesWon() 
        {
		    DbManager.updateSingleUserStat(uid, "gamesWon", ++gamesWon, 0);
	    }
	
	    public void addGamesRisky() 
        {
		    DbManager.updateSingleUserStat(uid, "gamesRisky", ++gamesRisky, 0);
	    }
	
	    public void addGamesRiskyWon() 
        {
		    DbManager.updateSingleUserStat(uid, "gamesRiskyWon", ++gamesRiskyWon, 0);
	    }
	
	    public void addGamesRiskyLost() 
        {
		    DbManager.updateSingleUserStat(uid, "gamesRiskyLost", ++gamesRiskyLost, 0);
	    }

	    public bool isAdmin() 
        {
		    return (status == 3);
	    }
        	    
    }
}
