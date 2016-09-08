using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch(type)
            {
                case "Cheese":
                    pizza = new ChicagoStyleCheesePizza();
                    break;
            }
            return pizza;
        }
    }
}
