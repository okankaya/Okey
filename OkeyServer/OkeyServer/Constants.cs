using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer {
    public static class Constants {
        public static string SERVER_AUTHORIZE = "aaa";
        public static string SERVER_JOINROOM = "aab";
        public static string SERVER_JOINGAME = "aac";
        public static string SERVER_JOINFRIENDGAME = "aad";
        public static string SERVER_CREATEGAME = "aae";
        public static string SERVER_GETROOMDATA = "aaf";
        public static string SERVER_RETURNTOROOM = "aag";
        public static string SERVER_STARTGAME = "aah";
        public static string SERVER_GETROOMS = "aai";
        public static string SERVER_GETCHIPS = "aak";
        public static string SERVER_LEAVEROOM = "aal";
        public static string SERVER_SIT = "aam";
        public static string SERVER_PLAYNOW = "aan";
        public static string SERVER_SHOUT = "aao";
        public static string SERVER_LEADERBOARD = "aap";
        public static string SERVER_SENDGIFT = "aar";
        public static string SERVER_FEED = "aat";
        public static string SERVER_GET_PROFILE = "aas";
        public static string SERVER_GETCOMPLAINTS = "aau";
        public static string SERVER_GETCOMPLAINT = "aav";
        public static string SERVER_DELETECOMPLAINTS = "aay";
        public static string SERVER_COMPLAIN = "aaz";
        public static string SERVER_GET_CONTEST_LIST = "aba";
        public static string SERVER_JOIN_CONTEST = "abb";
        public static string SERVER_MODIFYSTATUS = "abc";
        public static string SERVER_PENALIZEDLIST = "abd";
        public static string SERVER_NOW_PLAYING = "abe";
        public static string SERVER_CHECK_ONLINE = "abf";
        public static string SERVER_RESPOND_NOTIF = "abg";
        public static string SERVER_REMOVE_GAME = "abh";
        public static string SERVER_SET_HAPPY_HOUR = "abi";
        public static string SERVER_UPDATE_CITY = "abj";
        public static string SERVER_FRIENDREQ = "abk";
        public static string SERVER_FRIENDAPP = "abl";
        public static string SERVER_FRIENDDEL = "abm";
        public static string SERVER_FRIENDLIST = "abn";


        public static string GAME_TAKE = "baa";
        public static string GAME_THROW = "bab";
        public static string GAME_CHAT = "bac";
        public static string GAME_DOUBLE = "bad";
        public static string GAME_COMPLETE = "bae";
        public static string GAME_CHECKTIMEOUT = "baf";
        public static string GAME_GOSTERGE = "bag";

        public static string CLIENT_PLAYERCAME = "caa";
        public static string CLIENT_PLAYERLEFT = "cab";
        public static string CLIENT_STARTGAME = "cac";
        public static string CLIENT_PLAYERSIT = "cad";
        public static string CLIENT_PLAYERSTAND = "cae";
        public static string CLIENT_RECEIVEGIFT = "caf";
        public static string CLIENT_FRIENDSTATUS = "cag";
        public static string CLIENT_ANNOUNCEMENT = "cah";

        public static string ADMIN_CHAT_ACTION = "daa";
        public static string ADMIN_CHAT_MESSAGE = "dab";

        public static string STORE_GET_INVENTORY = "eaa";
        public static string STORE_BUY_ITEM = "eab";
        public static string STORE_GET_ITEMS = "eac";

        public static enum floodTypes {
            GAME_READY = 2001,
            GAME_TAKE = 2002,
            GAME_THROW = 2003,
            GAME_CHAT = 2004,
            GAME_RING = 2005,
            GAME_DOUBLE = 2006,
            GAME_COMPLETE = 2007
        }
        	
	    // userStatuses
	    public static enum userStatuses {
		    OFFLINE = 0,
		    ONLINE 	= 1,
		    WAITING = 2,
		    PLAYING = 3
	    }
	
        // User types
	    public static enum userTypes {
		    USER = 0,
		    VIP = 1,
		    MODERATOR = 2,
		    ADMIN = 3,
		    SUSPENDED = 98,
		    BANNED  = 99
	    }
	
	    public static enum feedTypes {
		    GAME_WON = 0,
		    GAME_LOST = 1,
		    FRIEND_BEATED = 2,
		    THREE_WINS = 3,
		    WELCOME	= 4,
		    GAME_CREATED = 5
		    //int PLAYING_GAME			= 6;
	    }
	
	    public static enum dailyBonus {
		    ONE	= 500,
		    TWO	= 600,
		    THREE = 700,
		    FOUR = 800,
		    FIVE = 1000
	    }

	    public static String apiKey = "14b5abb73359956859e375f765a3177b";
    	public static String apiSecret = "bace65ba8cfd9d5eae83f4d8be1f842c";

	    /***** Eskiler *****/	
	    public static String CROSSDOMAIN_POLICY_REQUEST;
	    public static String CROSSDOMAIN_POLICY;

        public static long SECOND = 1000;
        public static long MINUTE = 60 * SECOND;
        public static long HOUR = 60 * MINUTE;
        public static long DAY = 24 * HOUR;
        public static long WEEK = 7 * DAY;

	    public static int ROSTER_SIZE_MAX = 500;
	    public static double MIN_COST_FACTOR = 0.02;
	    public static double MAX_COST_FACTOR = 0.1;

	    public static long SERVER_POINTS_TIME_DIFF = 180000;
	    public static long MESSSAGE_TIME_DIFF = 1000;
	    public static long JOIN_GAME_TIME_DIFF = 1000;
	    public static long AUTH_FB_SIG_TIMEOUT = 200;
	    public static long ROOMDATA_UPDATE_INTERVAL = 3000;
	    public static long ROOMINFO_UPDATE_INTERVAL = 3000;
	    public static long TURN_TIME_FIRST = 34000;
	    public static long TURN_TIME = 25000;
	    public static long TURN_TIME_QUICK = 10000;
	    public static long TURN_TIME_FIRST_QUICK = 19000;


	    public static long ADDED_TIME_AFTER_TAKE = 5000;
	    public static int IDLE_TIME_IN_SECONDS = 150;
	
	    // contest
	    public static long CONTEST_UPDATE_INTERVAL = 1000 * 60 * 2;
	    public static int TOP_USER_COUNT = 3;
	    public static int USERS_AROUND_ME_COUNT = 3;
	
	
	    public static int CEZA_POINTS = -5;
	    public static long INITIAL_CHIPS = 8000;
	    public static long BONUS_PER_FRIEND = 100;
	    public static long CHIPS_PER_RESPOND = 25;
    }
}
