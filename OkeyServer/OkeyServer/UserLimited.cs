using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer
{
    class UserLimited
    {
        private long uid;
        private String name;
        private long chips;

        public UserLimited() { }

        public UserLimited(long uid, String name, long chips)
        {
            this.uid = uid;
            this.name = name;
            this.chips = chips;
        }

        public long getUid()
        {
            return uid;
        }

        public void setUid(long uid)
        {
            this.uid = uid;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public long getChips()
        {
            return chips;
        }

        public void setChips(long chips)
        {
            this.chips = chips;
        }
    }
}
