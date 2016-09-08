using Decorator;
using FactoryMethod;
using Observer;
using Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            PizzaStore NYPizzasStore = new NYPizzaStore();
            PizzaStore ChicagoPizzaStore = new ChicagoPizzaStore();

            NYPizzasStore.OrderPizza("Cheese");
            Console.WriteLine();
            ChicagoPizzaStore.OrderPizza("Cheese");

            Console.ReadLine();
        }
    }
}
