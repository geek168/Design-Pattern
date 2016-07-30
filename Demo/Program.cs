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
            ModelDuck duck = new ModelDuck(new FlyNoWay(), new Squeak());
            duck.Display();
            duck.Swim();
            duck.PerformFly();
            duck.PerformQuack();


            Console.ReadLine();
        }
    }
}
