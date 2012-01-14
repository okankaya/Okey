using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer
{
    class Gift
    {
        private int id;
        private String name;
        private int cost;
        private String className;
        private int categoryId;
        private String gender;
        private int costType;

        public Gift() { }

        public Gift(int id, String name, int cost, String className, int categoryId, int costType)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.className = className;
            this.categoryId = categoryId;
            this.costType = costType;
        }

        public int getCostType()
        {
            return costType;
        }

        public void setCostType(int costType)
        {
            this.costType = costType;
        }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public int getCost()
        {
            return cost;
        }
        public void setCost(int cost)
        {
            this.cost = cost;
        }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public String getClassName()
        {
            return className;
        }
        public void setClassName(String className)
        {
            this.className = className;
        }
        public int getCategoryId()
        {
            return categoryId;
        }
        public void setCategoryId(int categoryId)
        {
            this.categoryId = categoryId;
        }

        public String getGender()
        {
            return gender;
        }

        public void setGender(String gender)
        {
            this.gender = gender;
        }
    }
}
