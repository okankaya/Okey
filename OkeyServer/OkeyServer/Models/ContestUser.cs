using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer
{
    class ContestUser
    {
        //public properties
        public long uid { get; set; }
        public string name { get; set; }
        public int rank { get; set; }
        public int points { get; set; }

        /// <summary>
        /// Public contructor for contest user
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public ContestUser(long uid, String name, int rank) {
            this.uid = uid;
            this.name = name;
            this.rank = rank;
        }
    }
}
