using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory factory = new NYPizzaIngredientFactory();

            if(type == "Cheese")
            {
                pizza = new CheesePizza(factory);
                pizza.Name = "New York Style Cheese Pizza";
            }

            return pizza;
        }
    }
}
