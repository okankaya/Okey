﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer {
    public static class Constants {
        public static const string SERVER_AUTHORIZE = "aaa";
        public static const string SERVER_JOINROOM = "aab";
        public static const string SERVER_JOINGAME = "aac";
        public static const string SERVER_JOINFRIENDGAME = "aad";
        public static const string SERVER_CREATEGAME = "aae";
        public static const string SERVER_GETROOMDATA = "aaf";
        public static const string SERVER_RETURNTOROOM = "aag";
        public static const string SERVER_STARTGAME = "aah";
        public static const string SERVER_GETROOMS = "aai";
        public static const string SERVER_GETCHIPS = "aak";
        public static const string SERVER_LEAVEROOM = "aal";
        public static const string SERVER_SIT = "aam";
        public static const string SERVER_PLAYNOW = "aan";
        public static const string SERVER_SHOUT = "aao";
        public static const string SERVER_LEADERBOARD = "aap";
        public static const string SERVER_SENDGIFT = "aar";
        public static const string SERVER_FEED = "aat";
        public static const string SERVER_GET_PROFILE = "aas";
        public static const string SERVER_GETCOMPLAINTS = "aau";
        public static const string SERVER_GETCOMPLAINT = "aav";
        public static const string SERVER_DELETECOMPLAINTS = "aay";
        public static const string SERVER_COMPLAIN = "aaz";
        public static const string SERVER_GET_CONTEST_LIST = "aba";
        public static const string SERVER_JOIN_CONTEST = "abb";
        public static const string SERVER_MODIFYSTATUS = "abc";
        public static const string SERVER_PENALIZEDLIST = "abd";
        public static const string SERVER_NOW_PLAYING = "abe";
        public static const string SERVER_CHECK_ONLINE = "abf";
        public static const string SERVER_RESPOND_NOTIF = "abg";
        public static const string SERVER_REMOVE_GAME = "abh";
        public static const string SERVER_SET_HAPPY_HOUR = "abi";
        public static const string SERVER_UPDATE_CITY = "abj";
        public static const string SERVER_FRIENDREQ = "abk";
        public static const string SERVER_FRIENDAPP = "abl";
        public static const string SERVER_FRIENDDEL = "abm";
        public static const string SERVER_FRIENDLIST = "abn";
                      
        public static const string GAME_TAKE = "baa";
        public static const string GAME_THROW = "bab";
        public static const string GAME_CHAT = "bac";
        public static const string GAME_DOUBLE = "bad";
        public static const string GAME_COMPLETE = "bae";
        public static const string GAME_CHECKTIMEOUT = "baf";
        public static const string GAME_GOSTERGE = "bag";

        public static const string CLIENT_PLAYERCAME = "caa";
        public static const string CLIENT_PLAYERLEFT = "cab";
        public static const string CLIENT_STARTGAME = "cac";
        public static const string CLIENT_PLAYERSIT = "cad";
        public static const string CLIENT_PLAYERSTAND = "cae";
        public static const string CLIENT_RECEIVEGIFT = "caf";
        public static const string CLIENT_FRIENDSTATUS = "cag";
        public static const string CLIENT_ANNOUNCEMENT = "cah";
                      
        public static const string ADMIN_CHAT_ACTION = "daa";
        public static const string ADMIN_CHAT_MESSAGE = "dab";
                      
        public static const string STORE_GET_INVENTORY = "eaa";
        public static const string STORE_BUY_ITEM = "eab";
        public static const string STORE_GET_ITEMS = "eac";

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

	    public static const string apiKey = "14b5abb73359956859e375f765a3177b";
    	public static const string apiSecret = "bace65ba8cfd9d5eae83f4d8be1f842c";

	    /***** Eskiler *****/	
	    public static string CROSSDOMAIN_POLICY_REQUEST;
	    public static string CROSSDOMAIN_POLICY;

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
