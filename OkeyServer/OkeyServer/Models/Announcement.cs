using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer
{
    class Announcement
    {
        // Properties
        public int id { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public DateTime date { get; set; }
        public int featured { get; set; }
        public string imageUrl { get; set; }

        /// <summary>
        /// Constructor for the announcement class
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        /// <param name="date"></param>
        public Announcement(int myId, String myText, DateTime myDate)
        {
            this.id = myId;
            this.text = myText;
            this.date = myDate;
        }

    }
}
