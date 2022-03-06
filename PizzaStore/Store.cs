using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Store
    {
        #region Instace Fields
        private string _storeName;
        private double _dailyEarnings;

        //create three pizza, costumer, order, drink objects:
        private Pizza _pizza1;
        private Pizza _pizza2;
        private Pizza _pizza3;
        private Order _order1;
        private Order _order2;
        private Order _order3;
        private Costumer _costumer1;
        private Costumer _costumer2;
        private Costumer _costumer3;
        private Drink _drink1;
        private Drink _drink2;
        private Drink _drink3;
        #endregion

        #region Constructor
        public Store(string name)
        {
            _storeName = name;
            _dailyEarnings = 0;
            _order1 = new Order(1, _pizza1, _costumer1, _drink1, true);
            _order2 = new Order(2, _pizza2, _costumer2, _drink2, false);
            _order3 = new Order(3, _pizza3, _costumer3, _drink3, true);
            _pizza1 = new Pizza(1, "Magarita", 40);
            _pizza2 = new Pizza(2, "Hawai", 50);
            _pizza3 = new Pizza(4, "Veggie", 55);
            _costumer1 = new Costumer("Bob", "Jensen", "c1ks.dk", "12345678", true);
            _costumer2 = new Costumer("Tim", "Nielsen", "c2@ks.dk", "23456789", false);
            _costumer3 = new Costumer("Lea", "Hansen", "c3@ks.dk", "87654321", false);
            _drink1 = new Drink("Coca cola", 1.5, 25);
            _drink2 = new Drink("Gold Water", 0.5, 500);
            _drink3 = new Drink("Redwine", 0.75, 150);
        }
        #endregion

        #region Properties
        public string StoreName { get { return _storeName; } }
        public double DailyEarnings { get { return _dailyEarnings; } }
        #endregion

        #region Methods
        //starts the process
        public void Start()
        {
            SeeMenu();
           
            _order1.PrintItemsList(_pizza1, _costumer1, _drink1);
            _order2.PrintItemsList(_pizza2, _costumer2, _drink2);
            _order3.PrintItemsList(_pizza3, _costumer3, _drink3);
            GetDailyInfo();
        }
        //show menu
        public void SeeMenu()
        {
            Console.WriteLine(format: "{0, 50}", StoreName);
            Console.WriteLine(format: "{0, 43}", "Menu");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine(format: "{0, 44}", "Drinks");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine(format: "{0, 30} | {1, -15} | {2,0}", "1,5L", "Coca cola", "25 kr.");
            Console.WriteLine(format: "{0, 30} | {1, -15} | {2,0}", "1,5L", "Fanta", "25 kr.");
            Console.WriteLine(format: "{0, 30} | {1, -15} | {2,0}", "1,5L", "Sprite", "25 kr.");
            Console.WriteLine(format: "{0, 30} | {1, -15} | {2,0}", "0,5L", "Gold Water", "500 kr.");
            Console.WriteLine(format: "{0, 30} | {1, -15} | {2,0}", "0,75L", "Whitewine", "150 kr.");
            Console.WriteLine(format: "{0, 30} | {1, -15} | {2,0}", "0,75L", "RedWine", "150 kr.");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine(format: "{0, 44}", "Pizzas");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine(format: "{0, 30} | {1, -15} | {2,0}", "1.", "Magarita", "40 kr.");
            Console.WriteLine(format: "{0, 30} | {1, -15} | {2,0}", "2.", "Hawai", "50 kr.");
            Console.WriteLine(format: "{0, 30} | {1, -15} | {2,0}", "3.", "Mario", "55 kr.");
            Console.WriteLine(format: "{0, 30} | {1, -15} | {2,0}", "4.", "Veggie", "55 kr.");
            Console.WriteLine(format: "{0, 50}", "Delivery 40 kr");
            Console.WriteLine();
            Console.WriteLine("Press any key to get orders");
            Console.ReadKey();
            Console.WriteLine();
        }
        //method called at the end of the day to see how much earned and sold
        public void GetDailyInfo()
        {
            _dailyEarnings += Receipt.DailyEarnings;
            Console.WriteLine("Pizzas sold today: " + Pizza.PizzasSold);
            Receipt.GetDiscountUses();
            Console.WriteLine($"{_storeName} has earned {_dailyEarnings:C} today");
        }
        public override string ToString()
        {
            return $"{_storeName}";
        }
        #endregion
    }
}

