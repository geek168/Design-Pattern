using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "CheesePizza":
                    pizza = new CheesePizza();
                    break;
                case "ClamPizza":
                    pizza = new ClamPizza();
                    break;
                case "VeggiePizza":
                    pizza = new VeggiePizza();
                    break;
                case "Pepperoni":
                    pizza = new PepperoniPizza();
                    break;
            }
            return pizza;
        }
    }
}
