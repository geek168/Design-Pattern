using Decorator;
using FactoryMethod;
using Observer;
using Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Tea tea = new Tea();
            tea.PrepareReceipe();

            Console.ReadLine();
        }
    }
}
