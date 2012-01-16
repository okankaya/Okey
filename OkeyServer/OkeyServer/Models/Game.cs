using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer.Models
{
    class Game
    {
        public long gameID { get; set; }
        public User owner { get; set; }
        public bool isVIP { get; set; }
        public long gameCost { get; set; }
        public bool gameStart { get; set; }
        public OkeyDeck deck;
        public List<User> spectators = new List<User>();
        public Dictionary<int, User> userList = new Dictionary<int, User>();

        public Game(User u, long cost)
        {
            //gameID = Database'deki en son numara + 1
            owner = u;
            this.isVIP = isVIP;
            gameCost = cost;
            gameStart = false;

        }

        public void initializeDeck() //yalan
        {
            this.deck = new OkeyDeck();
        }

        public int sit(User u, int position) // yalan
        {
            return 1;
        }

        public void addSpectator(User u)
        {
            spectators.Add(u);
        }

        public void removeUser(int position)
        {
            if (userList.Count > 1)
            {

            }
        }
    }
}

