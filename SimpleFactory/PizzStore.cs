using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class PizzStore
    {
        SimplePizzaFactory SimplePizzaFactory;

        public PizzStore(SimplePizzaFactory factory)
        {
            SimplePizzaFactory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = SimplePizzaFactory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
