using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer
{
    class Product
    {
        //Public properties
        public int id { get; set; }
        public string text { get; set; }
        public int chips { get; set; }
        public int fbChips { get; set; }
        public int realMoney { get; set; }
        public int discountMoney { get; set; }
        public int discountFbCredits { get; set; }
        public int isDiscountEnabled { get; set; }

        /// <summary>
        /// Public constructor for product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        /// <param name="jijiChips"></param>
        /// <param name="fbChips"></param>
        public Product(int id, String text, int jijiChips, int fbChips)
        {
            this.id = id;
            this.text = text;
            this.chips = jijiChips;
            this.fbChips = fbChips;
        }

    }
}
