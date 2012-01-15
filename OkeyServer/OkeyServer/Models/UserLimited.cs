using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer
{
    class UserLimited
    {
        //Public properties
        public long uid { get; set; }
        public string name { get; set; }
        public long chips { get; set; }

        /// <summary>
        /// Public constructor for user limited?
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="name"></param>
        /// <param name="chips"></param>
        public UserLimited(long uid, String name, long chips)
        {
            this.uid = uid;
            this.name = name;
            this.chips = chips;
        }
    }
}
