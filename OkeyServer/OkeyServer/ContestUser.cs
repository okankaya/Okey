using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer
{
    class ContestUser
    {
        private long uid;
        private String name;
        private int rank;
        private int points;

        public ContestUser() { }

        public ContestUser(long uid, String name, int rank)
        {
            this.uid = uid;
            this.name = name;
            this.rank = rank;
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

        public int getRank()
        {
            return rank;
        }

        public void setRank(int rank)
        {
            this.rank = rank;
        }

        public int getPoints()
        {
            return points;
        }

        public void setPoints(int points)
        {
            this.points = points;
        }
    }
}
