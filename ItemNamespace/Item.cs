using System;

namespace ItemNamespace
{
    public class Item
    {
        protected string item_name;
        protected double item_price;
        protected int total_price;
        protected int quantity;

        public Item(string name, double price, int quantity)
        {
            item_name = name;
            item_price = price;
            this.quantity = quantity;
        }

        public virtual double getTotalPrice()
        {
            return item_price * quantity;
        }

        public virtual void setPayment(double amount)
        {

        }
    }
}