using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer.Models {
    class Room 
    {
        private Dictionary<long, Game> pendingGames;
	    private Dictionary<long, Game> playingGames;
	    private Dictionary<long, User> users;

        public long id { get; set; }

        public string name { get; private set; }
        public int maxUsers { get; private set; }
        public int priority { get; private set; }

        public long minChips { get; private set; }
        public long minStarterChips { get; private set; }
        public long maxStarterChips { get; private set; }

        private bool vip;
        private List<long> staticGameValues = new List<long>();
        private List<Game> staticGameList = new List<Game>();
        
        //private JSONArray allGameList;
	    private long roomDataUpdateTime;
	    //private final Object roomDataLock = new Object();

	    public Room() // bu constructor kullanilmiyor gibi
	    {
		    //this.users = new ConcurrentHashMap<Long, User>();
		    //this.pendingGames = new ConcurrentHashMap<Long, Game>();
		    //this.playingGames = new ConcurrentHashMap<Long, Game>();
		    //this.vip = false;
	    }

	    public Room(long id, String name, int maxUsers, long minChips, long minStarterChips, long maxStarterChips, int priority) 
        {
		    this.id = id;
		    this.name = name;
		    this.maxUsers = maxUsers;
		    this.minChips = minChips;
		    this.minStarterChips = minStarterChips;
		    this.maxStarterChips = maxStarterChips;
		    this.priority = priority;
		    //this.users = new ConcurrentHashMap<Long, User>(maxUsers);
		    //this.pendingGames = new ConcurrentHashMap<Long, Game>();
		    //this.playingGames = new ConcurrentHashMap<Long, Game>();
		    this.vip = false;
            //		this.staticGameValues = staticGameValues;

		    //this.roomDataUpdateTime = System.currentTimeMillis();
		    updateRoomData();
	    }

        public void addUser(long userId, User user) 
        {
		    //users.put(userId, user);
	    }

	    public void removeUser(long userId) 
        {
		    //users.remove(userId);
	    }

        public int getUserCount() 
        {
		    //return users.size() + getPendingUserCount() + getPlayingUserCount();
            return 1;
	    }

        //public ConcurrentHashMap<Long, Game> getPendingGames() {
		//return pendingGames;
	    //}
	
	    /// <summary>
	    /// Returns the number of pending users
	    /// </summary>
	    /// <returns></returns>
        public int getPendingUserCount()
        {
		    int userCount = 0;
            //for (Game g : pendingGames.values()) {
			//    userCount += g.getUsers().size();
		    //}
		    return userCount;
	    }       

        //public ConcurrentHashMap<Long, Game> getPlayingGames() 
        //{
		//    return playingGames;
	    //}
	
	    public int getPlayingUserCount() 
        {
		    int userCount = 0;
		    //for (Game g : playingGames.values()) {
			//userCount += g.getUsers().size();
		    //}
		    return userCount;
	    }
	
	    public int getGameCount() 
        {
		    //return playingGames.size() + pendingGames.size();
	        return 1;
        }

	    public bool isVip()
        {
		    return vip;
	    }

	    public void setVip(bool vip) 
        {
		    this.vip = vip;
	    }

	    //public ConcurrentHashMap<Long, User> getUsers() {
		//    return users;
	    //}

	    //public void addGame(Game game) {
		//    pendingGames.put(game.getId(), game);
	    //}

	    public void removeGame(long gameId) 
        {
		    //Game tmp = pendingGames.remove(gameId);
            //		if (tmp!=null) staticGameList.remove(tmp);
		    //tmp = playingGames.remove(gameId);
            //		if (tmp!=null) staticGameList.remove(tmp);
	    }

	    public Game getGame(long gameId, bool isAdmin) 
        {
		    //if( pendingGames.containsKey(gameId) ) {
			//   return pendingGames.get(gameId);
		    //} else if( isAdmin ) {
			//    return playingGames.get(gameId);
		    //}
	        return null;
	    }

	    public void moveToPlaying(long gameId) 
        {
		    /*Game g = pendingGames.remove(gameId);

    		if (g != null) 
            {
			    playingGames.put(gameId, g);
			    for (User u : g.getUsers().values()) {
				    u.changePresence(userStatuses.PLAYING);
			    }
		    }*/
	    }

	    public void moveToPending(long gameId) 
        {
		    //Game g = playingGames.remove(gameId);

    		//if (g != null) {
	    		//pendingGames.put(gameId, g);
		    	//for (User u : g.getUsers().values()) {
			    //	u.changePresence(userStatuses.WAITING);
			    //}
		    //}
	    }

	    /*
        public JSONArray getGameList() throws JSONException {
		    synchronized (roomDataLock) {
			    long now = System.currentTimeMillis();
			    if (now - this.roomDataUpdateTime > Constants.ROOMDATA_UPDATE_INTERVAL) {
				    this.roomDataUpdateTime = now;
				    updateRoomData();
			    }
		    }
		    return allGameList;
	    }*/

	    public void updateRoomData() 
        {
		    //JSONArray games = new JSONArray();
            //		List<Long> staticValues = new ArrayList<Long>(this.staticGameValues);

		    int gameCount = 0;
            /*for (Game g : getPendingGames().values()) {
                boolean nobodyThere = true;
                for (User u : g.getUsers().values()) {
                    if (u.getConnection()!=null) {
                        nobodyThere = false;
                    } else {
                        g.removeUser(u);
                    }
                }
                //			if (!staticGameList.contains(g)){
                if (nobodyThere) {
                    for (User u:g.getSpectators()) {
                        if (u.getConnection()!=null) {
                            nobodyThere = false;
                        } else {
                            g.removeUser(u);
                        }
                    }
                }
                if (nobodyThere) {
                    removeGame(g.getId());
                    continue;
                }
			
            //			if (staticValues.contains(g.getGameCost()))
            //				staticValues.remove(g.getGameCost());
			
            JSONObject gameInfo = new JSONObject();
            gameInfo.put("id", g.getId());
            if (g.getOwner()!=null){
                gameInfo.put("name", g.getOwner().getName());
            } else {
                gameInfo.put("name", g.getName());
            }
            gameInfo.put("gameCost", g.getGameCost());
            gameInfo.put("userCount", g.getUsers().size() + g.getSpectators().size());
            gameInfo.put("isActive", false);
            gameInfo.put("isRisky", g.isRisky());
            gameInfo.put("isQuick", g.isQuick());
            games.put(gameInfo);
            if (++gameCount > 100) {
                logger.warn("[gamecount] " + id + " " + name);
                break;
            }
            }
		
            for (Game g : getPlayingGames().values()) {
                boolean nobodyThere = true;
                for (User u : g.getUsers().values()) {
                    if (u.getConnection()!=null) {
                        nobodyThere = false;
                    } else {
                        g.removeUser(u);
                    }
                }
				
                if (nobodyThere) {
                    for (User u:g.getSpectators()) {
                        if (u.getConnection()!=null) {
                            nobodyThere = false;
                        } else {
                            g.removeUser(u);
                        }
                    }
                }
                if (nobodyThere) {
                    removeGame(g.getId());
                    continue;
                }

			
                JSONObject gameInfo = new JSONObject();
                gameInfo.put("id", g.getId());
                if (g.getOwner()!=null){
                    gameInfo.put("name", g.getOwner().getName());
                } else {
                    gameInfo.put("name", g.getName());
                }
                gameInfo.put("gameCost", g.getGameCost());
                gameInfo.put("userCount", g.getUsers().size() + g.getSpectators().size());
                gameInfo.put("isActive", true);
                gameInfo.put("isRisky", g.isRisky());
                gameInfo.put("isQuick", g.isQuick());
			
                games.put(gameInfo);
                if (++gameCount > 100) {
                    logger.warn("[gamecount] " + id + " " + name);
                    break;
                }
            }
		
                //		while (staticValues.size()>0) {
                //			Long gameCost = staticValues.remove(0);
                //			Game g = new Game();
                //			g.setGameCost(gameCost);
                //			g.setName("Masa-" + (staticGameValues.indexOf(gameCost)+1));
                //			addGame(g);
                //			staticGameList.add(g);
                //		}
		
                        allGameList = games;
                             * */
        }
    }
}
