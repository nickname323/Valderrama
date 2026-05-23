using System;

namespace ItemNamespace
{
    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name,
                              double price,
                              int quantity,
                              double discount)
            : base(name, price, quantity)
        {
            item_discount = discount * 0.01;

            double discountValue =
                item_discount * item_price;

            discounted_price =
                item_price - discountValue;
        }

        public override double getTotalPrice()
        {
            return discounted_price * quantity;
        }

        public override void setPayment(double amount)
        {
            payment_amount = amount;

            change = payment_amount -
                     getTotalPrice();
        }

        public double getChange()
        {
            return change;
        }
    }
}