using System;
using System.Collections.Generic;
using System.Text;


namespace PizzaStore
{
    public class Order
    {
        #region Instace Fields
        private int _id;
        private Receipt _receipt;
        #endregion

        #region Constructor
        public Order(int id, Pizza pizza, Costumer costumer, Drink drink, bool delivery)
        {
            _id = id;
            _receipt = new Receipt(delivery);
        }
        //if they dont want drinks
        public Order(int id, Pizza pizza, Costumer costumer, bool delivery)
        {
            _id = id;
            _receipt = new Receipt(delivery);
        }
        #endregion

        #region Properties
        public int Id { get { return _id; } }
        #endregion

        #region Methods
        //prints Info for costumer, pizza and drinks per order
        public void PrintItemsList(Pizza pizza, Costumer costumer, Drink drink)
        {
            Console.WriteLine($"{costumer} ");
            Console.WriteLine($"{pizza}");
            Console.WriteLine($"{drink}");
            _receipt.CalculateDiscount(pizza.PizzaPrice, drink.DrinkPrice);   
        }
        public override string ToString()
        {
            return $"Order ID {_id}:";
        }
        #endregion
    }
}
