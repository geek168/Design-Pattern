using Decorator;
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

            Beverage beverage = new Espresso();
            beverage = new Milk(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);
            Console.WriteLine(beverage.GetDescription());
            Console.WriteLine(beverage.Cost());

            Console.ReadLine();
        }
    }
}
