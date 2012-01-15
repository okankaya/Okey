using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer
{
    class Gift
    {
        //public properties
        public int id { get; set; }
        public string name { get; set; }
        public int cost { get; set; }
        public string className { get; set; }
        public int categoryId { get; set; }
        public string gender { get; set; }
        public int costType { get; set; }

        /// <summary>
        /// Public constructor for gift
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="cost"></param>
        /// <param name="className"></param>
        /// <param name="categoryId"></param>
        /// <param name="costType"></param>
        public Gift(int id, String name, int cost, String className, int categoryId, int costType)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.className = className;
            this.categoryId = categoryId;
            this.costType = costType;
        }
    }
}
