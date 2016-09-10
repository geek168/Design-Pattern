using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ClamPizza : Pizza
    {
        IPizzaIngredientFactory IPizzaIngredientFactory;

        public ClamPizza(IPizzaIngredientFactory factory)
        {
            IPizzaIngredientFactory = factory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            dough = IPizzaIngredientFactory.CreateDough();
            sauce = IPizzaIngredientFactory.CreateSauce();
            cheese = IPizzaIngredientFactory.CreateCheese();
            clam = IPizzaIngredientFactory.CreateClam();
        }
    }
}
