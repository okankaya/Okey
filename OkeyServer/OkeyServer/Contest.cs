using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer
{
    class Contest
    {
        private int id;
        private String name;
        private DateTime startDate;
        private DateTime endDate;
        private String reward;

        public Contest() { }

        public Contest(String name, DateTime startDate, DateTime endDate, String reward)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.reward = reward;
        }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public DateTime getStartDate()
        {
            return startDate;
        }
        public void setStartDate(DateTime startDate)
        {
            this.startDate = startDate;
        }
        public DateTime getEndDate()
        {
            return endDate;
        }
        public void setEndDate(DateTime endDate)
        {
            this.endDate = endDate;
        }
        public String getReward()
        {
            return reward;
        }
        public void setReward(String reward)
        {
            this.reward = reward;
        }
    }
}
