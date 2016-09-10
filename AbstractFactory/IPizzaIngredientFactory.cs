﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        List<Veggie> CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClam();
    }
}
