using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer
{
    class Notification
    {
        private int id;
        private long fromUid;
        private String fromName;
        private long toUid;
        private int type;
        private String message;
        private DateTime date;
        private int responded;

        public Notification() { }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public long getFromUid()
        {
            return fromUid;
        }
        public void setFromUid(long fromUid)
        {
            this.fromUid = fromUid;
        }
        public String getFromName()
        {
            return fromName;
        }
        public void setFromName(String fromName)
        {
            this.fromName = fromName;
        }
        public long getToUid()
        {
            return toUid;
        }
        public void setToUid(long toUid)
        {
            this.toUid = toUid;
        }
        public int getType()
        {
            return type;
        }
        public void setType(int type)
        {
            this.type = type;
        }
        public String getMessage()
        {
            return message;
        }
        public void setMessage(String message)
        {
            this.message = message;
        }
        public DateTime getDate()
        {
            return date;
        }
        public void setDate(DateTime date)
        {
            this.date = date;
        }

        public int getResponded()
        {
            return responded;
        }

        public void setResponded(int responded)
        {
            this.responded = responded;
        }
    }
}
