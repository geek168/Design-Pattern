using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        protected string Dough;
        protected string Sauce;
        protected List<string> Toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Prepare " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding Sauce...");
            Console.WriteLine("Adding toppings");
            Toppings.ForEach(s =>
            {
                Console.WriteLine(" " + s);
            });
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Please pizza in official box");
        }
    }
}
