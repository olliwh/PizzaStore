using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Drink
    {
        #region Instance Fields
        private string _drinkName;
        private double _drinkAmountLiter;
        private int _drinkPrice;
        #endregion

        #region Constructor
        public Drink(string name, double liter, int price)
        {
            _drinkName = name;
            _drinkAmountLiter = liter;
            _drinkPrice = price;
        }
        #endregion

        #region Properties
        public string DrinkName { get { return _drinkName; } }
        public int DrinkPrice { get { return _drinkPrice; } }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{_drinkName} {_drinkAmountLiter}L {_drinkPrice:C}";
        }
        #endregion
    }
}

