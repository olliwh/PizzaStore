using System;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("Big Mammas Pizzaria");
            store.Start();
        }
    }
}
