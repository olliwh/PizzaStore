using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Receipt
    {
        #region Instace Fields

        private double _tax;//25%
        private int _deliveryFee; //40 kr
        private double _priceOfItems;
        private double _totalPrice;
        private bool _delivery;
        private static int _discountUses200;
        private static int _discountUses300;
        private DateTime _dayOfOrder;   
        private static double _dailyEarnings;
        #endregion

        #region Constructor
        public Receipt(bool delivery)
        {
            _delivery = delivery;
            _tax = 0.25;
            _deliveryFee = 40;
            _dayOfOrder = DateTime.Now;
        }
        #endregion

        #region Properties

        public double TotalPrice { get { return _totalPrice; } }
        public int Delivery { get { return _deliveryFee; } set { _deliveryFee = value; } }
        public double Tax { get { return _tax; } set { _tax = value; } }
        //store earning is sent to store, to print daily earnings
        public static double DailyEarnings { get { return _dailyEarnings; } set { _dailyEarnings = value; } }
        #endregion

        //If pizza + drinks is above 200 you get 10% discount and a boolean = true
        //If pizza + drinks is above 300 you get 15% discount and a boolean = true
        public void CalculateDiscount(int pizzaPrice, int drinkPrice)
        {
            _priceOfItems = pizzaPrice + drinkPrice;

            bool gotDiscount200 = false;
            bool gotDiscount300 = false;
            double savedAmount200 = _priceOfItems * 0.1;

            double savedAmount300 = _priceOfItems * 0.15; ;

            if (_priceOfItems > 200 && _priceOfItems < 300)
            {
                _priceOfItems = _priceOfItems * 0.9;
                _discountUses200++;
                gotDiscount200 = true;
            }
            else if (_priceOfItems > 300)
            {
                _priceOfItems = _priceOfItems * 0.85;
                _discountUses300++;
                gotDiscount300 = true;
            }
            PrintDiscount(gotDiscount200, gotDiscount300, savedAmount200, savedAmount300);
        }


        //if you got a discout it will show what you saves
        private void PrintDiscount(bool gotDiscount200, bool gotDiscount300, double savedAmount200, double savedtAmount300)
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            if (gotDiscount200) Console.WriteLine($"Discount of 10%. You saved {savedAmount200:C}");
            if (gotDiscount300) Console.WriteLine($"Discount of 15%. You saved {savedtAmount300:C}");
            CalculateTotalPrice();
        }
        //total price with tax and delivery
        private void CalculateTotalPrice()
        {
            string delivery = string.Empty;
            if (_delivery)
            {
                _totalPrice = _priceOfItems * (_tax + 1) + _deliveryFee;
                delivery = " and delivery";
            }
            else
                _totalPrice = _priceOfItems * (_tax + 1);
            PrintTotal(delivery);
            _dailyEarnings += _totalPrice;
        }
        

        private void PrintTotal(string delivery)
        {
            Console.WriteLine($"Your total with tax{delivery}: {_totalPrice:C}");
            Console.WriteLine($"sub-total:  {_priceOfItems:C}");
            Console.WriteLine($"Tax({_tax * 100}%): {_priceOfItems * (_tax + 1):C}");;
            Console.WriteLine(_dayOfOrder);
            Console.WriteLine();
            Console.WriteLine();
        }
        //so the store can see when and what discounts are used
        public static void GetDiscountUses()
        {
            Console.WriteLine($"Number of discount for over 200: {_discountUses200}");
            Console.WriteLine($"Number of discount for over 300: {_discountUses300}");
        }
        public override string ToString()
        {
            return "This is your receit";
        }
    }
}
