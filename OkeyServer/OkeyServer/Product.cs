using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer
{
    class Product
    {
        private int id;
        private String text;
        private int chips;
        private int fbChips;
        private int realMoney;
        private int discountMoney;
        private int discountFbCredits;
        private int isDiscountEnabled;

        public Product() { }

        public Product(int id, String text, int jijiChips, int fbChips)
        {
            this.id = id;
            this.text = text;
            this.chips = jijiChips;
            this.fbChips = fbChips;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public String getText()
        {
            return text;
        }

        public void setText(String text)
        {
            this.text = text;
        }

        public int getChips()
        {
            return chips;
        }

        public void setChips(int Chips)
        {
            this.chips = Chips;
        }

        public int getFbChips()
        {
            return fbChips;
        }

        public void setFbChips(int fbChips)
        {
            this.fbChips = fbChips;
        }

        public int getRealMoney()
        {
            return realMoney;
        }

        public void setRealMoney(int realMoney)
        {
            this.realMoney = realMoney;
        }

        public int getDiscountMoney()
        {
            return discountMoney;
        }

        public void setDiscountMoney(int discountMoney)
        {
            this.discountMoney = discountMoney;
        }

        public int getDiscountFbCredits()
        {
            return discountFbCredits;
        }

        public void setDiscountFbCredits(int discountFbCredits)
        {
            this.discountFbCredits = discountFbCredits;
        }

        public int getIsDiscountEnabled()
        {
            return isDiscountEnabled;
        }

        public void setIsDiscountEnabled(int isDiscountEnabled)
        {
            this.isDiscountEnabled = isDiscountEnabled;
        }
    }
}
