using System;
using System.Collections.Generic;
using System.Text;


namespace PizzaStore
{
    public class Pizza
    {
        #region Instance Fields
        private string _pizzaName;
        private int _pizzaPrice;
        private int _pizzaNumber;
        private static int _pizzasSold;
        #endregion

        #region Constructor
        public Pizza(int number, string name, int price)
        {
            _pizzaNumber = number;
            _pizzaName = name;
            _pizzaPrice = price;
            _pizzasSold++;
        }
        #endregion

        #region Properties
        public int PizzaNumber { get { return _pizzaNumber; } }
        public string PizzaName { get { return _pizzaName; } }
        public int PizzaPrice { get { return _pizzaPrice; } }
        public static int PizzasSold { get { return _pizzasSold; } set { _pizzasSold = value; } }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Nr. {_pizzaNumber}, {_pizzaName}, {_pizzaPrice:C}";
        }
        #endregion

    }
}
