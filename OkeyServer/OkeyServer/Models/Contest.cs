using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer
{
    class Contest
    {
        //public properties
        public int id { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string reward { get; set; }

        /// <summary>
        /// Public contructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="reward"></param>
        public Contest(String name, DateTime startDate, DateTime endDate, String reward)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.reward = reward;
        }
    }
}
