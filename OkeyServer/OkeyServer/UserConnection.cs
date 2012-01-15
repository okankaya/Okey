using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace OkeyServer {
    class UserConnection {

        public UserConnection(string msg) {
            try {
                //JsonTextWriter jsonObj = new JsonTextWriter(

            }
            catch (JsonReaderException) {
                
                throw;
            }
        }

        private void processMessage(string msg) {
            string myMsg = msg.TrimStart('k');

            switch (myMsg) {
                case Constants.SERVER_JOINGAME:
                    //joinRoom(msg);
                    break;
		        case Constants.SERVER_JOINFRIENDGAME:
                    //joinFriendGame(message);
                    break;
                case Constants.SERVER_CREATEGAME: 
                    //createGame(message);
                    break;
                case Constants.SERVER_GETROOMDATA:
                    //getRoomData(message);
                    break;
                case Constants.SERVER_RETURNTOROOM:
                    //returnToRoom(0);
                    break;
                case Constants.SERVER_STARTGAME:
                    //startGame(message);
                    break;
                case Constants.SERVER_GETROOMS:
                    //getRooms(message);
                    break;
                case Constants.SERVER_GETCHIPS:
                    //getChips(message);
                    break;
                case Constants.SERVER_LEAVEROOM:
					/*leaveRoom();
					JSONObject response = new JSONObject();
					response.put("k", commands.SERVER_LEAVEROOM);
					response.put("resultCode", 0);
					deliver(response);*/
					break;
				case Constants.SERVER_SIT:
					//gameSit(message);
					break;
				case Constants.SERVER_PLAYNOW:
					//playNow(message);
					break;
				case Constants.SERVER_SHOUT:
					//shout(message);
					break;
				case Constants.SERVER_LEADERBOARD:
					//getLeaderBoard(message);
					break;
				case Constants.SERVER_SENDGIFT:
					//sendGift(message);
					break;
				case Constants.SERVER_GET_PROFILE:
					//getProfile(message);
					break;
				case Constants.SERVER_GETCOMPLAINTS:
					//getComplaints(message);
					break;
				case Constants.SERVER_GETCOMPLAINT:
					//getComplaint(message);
					break;
				case Constants.SERVER_DELETECOMPLAINTS:
					//deleteComplaints(message);
					break;
				case Constants.SERVER_COMPLAIN:
					//complain(message);
					break;
				case Constants.SERVER_GET_CONTEST_LIST:
					//getContestList(message);
					break;
				case Constants.SERVER_JOIN_CONTEST:
					//joinContest(message);
					break;
				case Constants.SERVER_MODIFYSTATUS:
					//modifyStatus(message);
					break;
				case Constants.SERVER_PENALIZEDLIST:
					//penalizedList(message);
					break;
				case Constants.SERVER_NOW_PLAYING:
					//nowPlayingRadio(message);
					break;
				case Constants.SERVER_CHECK_ONLINE:
					//checkOnline(message);
					break;
				case Constants.SERVER_RESPOND_NOTIF:
					//respondNotification(message);
					break;
				case Constants.SERVER_REMOVE_GAME:
					//removeGame(message);
					break;
				case Constants.SERVER_SET_HAPPY_HOUR:
					//setHappyHour(message);
					break;
				case Constants.SERVER_UPDATE_CITY:
					//updateCity(message);
					break;
				case Constants.SERVER_FRIENDREQ:
					//friendRequest(message);
					break;
				case Constants.SERVER_FRIENDAPP:
					//friendAppove(message);
					break;
				case Constants.SERVER_FRIENDDEL:
					//friendDel(message);
					break;
				case Constants.SERVER_FRIENDLIST:
					//friendList(message);
					break;
				case Constants.GAME_TAKE:
					//gameCmdTake(message);
					break;
				case Constants.GAME_THROW:
					//gameCmdThrow(message);
					break;
				case Constants.GAME_CHAT:
					//gameCmdChat(message);
					break;
				case Constants.GAME_DOUBLE:
					//gameCmdDouble(message);
					break;
				case Constants.GAME_COMPLETE:
					//gameCmdComplete(message);
					break;
				case Constants.GAME_CHECKTIMEOUT:
					//gameCheckTimeout();
					break;
				case Constants.GAME_GOSTERGE:
					//gameGosterge(message);
					break;
				case Constants.STORE_GET_ITEMS:
					//getStoreItems(message);
					break;
				case Constants.STORE_GET_INVENTORY:
					//getInventory(message);
					break;
                default:
                    //logger.error("Command without a matching serverCommand: " + command);
                    break;
            }  
        
        }

    }
}
