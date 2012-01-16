using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer.Models {
    class Notification
    {
        //Public properties
        public int id { get; set; }
        public long fromUid { get; set; }
        public string fromName { get; set; }
        public long toUid { get; set; }
        public int type { get; set; }
        public string message { get; set; }
        public DateTime date { get; set; }
        public int responded { get; set; }


        public Notification() { }



    }
}
