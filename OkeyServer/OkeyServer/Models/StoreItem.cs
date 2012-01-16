using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer.Models
{
    class StoreItem
    {
        public int id { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public int type { get; set; }
        public bool isExpirable { get; set; }
        public bool isLimitedTime { get; set; }
        public bool isLimitedCount { get; set; }
        public int expirePeriod { get; set; }
        public DateTime expireDate { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int itemsLeft { get; set; }
        public int cost { get; set; }


        public StoreItem() { }

        /// <summary>
        /// Public constructor for store item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="isExpirable"></param>
        /// <param name="isLimitedTime"></param>
        /// <param name="isLimitedCount"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="itemsLeft"></param>
        public StoreItem(int id, String name, String description, int type, bool isExpirable, bool isLimitedTime, bool isLimitedCount, DateTime startDate, DateTime endDate, int itemsLeft)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.type = type;
            this.isExpirable = isExpirable;
            this.isLimitedTime = isLimitedTime;
            this.isLimitedCount = isLimitedCount;
            this.startDate = startDate;
            this.endDate = endDate;
            this.itemsLeft = itemsLeft;
        }
    }
}
