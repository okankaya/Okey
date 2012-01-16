using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer.Models {
    class Zone {
        // Properties
        public long id { get; set; }
        public string name { get; set; }

        //private HashMap<Long, Room> rooms = new HashMap<Long, Room>();
	    //private JSONArray roomInfo;
	    private long roomInfoUpdateTime;
	    //private final Object roomInfoLock = new Object();

	    public Zone(long id, String name) {
		    this.id = id;
		    this.name = name;
	    }

	    /*public Room addRoom(Room room) {
		    return rooms.put(room.getId(), room);
	    }*/
	
	    /*public JSONArray getRoomInfo() throws JSONException
	    {
		    bool update = false;
		    synchronized(roomInfoLock)
		    {
			    long now = System.currentTimeMillis();
			    if(now - this.roomInfoUpdateTime > Constants.ROOMINFO_UPDATE_INTERVAL)
			    {
				    this.roomInfoUpdateTime = now;
				    update = true;
			    }
		    }
		    if(update)
		    {
			    updateRoomInfo();
		    }
		    return roomInfo;
	    }*/

	    public void updateRoomInfo() 
        {
		    //JSONArray roomInfoArray = new JSONArray();

		    // ConcurrentLinkedQueue, iterator
		    /*for (Room room : rooms.values()) {
			    //int userCount = room.getUserCount();
			    //if (userCount < room.getMaxUsers()) // TODO kontrol yapilmiyor
			    //{
				    JSONObject roomInfo = new JSONObject();
				    roomInfo.put("id", room.getId());
				    roomInfo.put("name", room.getName());
				    roomInfo.put("minchips", room.getMinChips());
				    roomInfo.put("mincost", room.getMinStarterChips());
				    roomInfo.put("maxcost", room.getMaxStarterChips());
				    roomInfo.put("priority", room.getPriority());
				    roomInfo.put("users", room.getUserCount());
				    roomInfoArray.put(roomInfo);
			    //}
		    }
		    this.roomInfo = roomInfoArray;
             */
        }

	    /**
	     * Getters & Setters
	     **/
	    /*public HashMap<Long, Room> getRooms() {
		    return rooms;
	    }
	
	    public Room getRoom(Long roomId) {
		    return rooms.get(roomId);
	    }

	    public Room joinRandomRoom(Long chips) {
		    ArrayList<Room> availableRooms = new ArrayList<Room>();
		
		    for (Room r : rooms.values()) {
			    if (r.getMinChips() < chips && r.getMaxUsers() > r.getUserCount()) {
				    availableRooms.add(r);
			    }
		    }
		
		    if( availableRooms.size() > 0 ) {
			    Random rand = new Random();
			    int index = rand.nextInt(availableRooms.size());
			    return availableRooms.get(index);
		    }
		
		    return null;
	    }*/
    }
}
