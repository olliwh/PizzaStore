using System;
using System.Collections.Generic;
using System.Text;


namespace PizzaStore
{
    public class Costumer
    {
        #region Instace Fields
        private string _costumerFirstName;
        private string _costumerLastName;
        private string _mail;
        private string _phone;
        private bool _payInCash;
        #endregion

        #region Constructor
        public Costumer(string firstName, string lastName, string mail, string phone, bool payInCash)
        {
            _costumerFirstName = firstName;
            _costumerLastName = lastName;
            _mail = mail;
            _phone = phone;
            _payInCash = payInCash;
        }
        #endregion

        #region Properties
        public string CostumerName { get { return $"{_costumerFirstName} {_costumerLastName}"; } }

        //Mail must contain @
        public String Mail
        {
            get
            {
                bool b = _mail.Contains("@");
                if (b) return _mail;
                else
                    return "Invalid E-mail '@' missing";
            }
        }
        public string Phone { get { return _phone; } }

        #endregion

        #region Methods
        public override string ToString()
        {
            string isCash = "Credit cart";
            if (_payInCash) isCash = "Cash";
            return "Costumer Info! " + $"Name: {CostumerName}, Mail: {Mail}, Phone: {_phone}, Payment: {isCash}";
        }
        #endregion
    }
}

