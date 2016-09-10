using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CheesePizza : Pizza
    {
        IPizzaIngredientFactory IPizzaIngredientFactory;

        public CheesePizza(IPizzaIngredientFactory factory)
        {
            IPizzaIngredientFactory = factory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            dough = IPizzaIngredientFactory.CreateDough();
            sauce = IPizzaIngredientFactory.CreateSauce();
            cheese = IPizzaIngredientFactory.CreateCheese();
        }
    }
}
