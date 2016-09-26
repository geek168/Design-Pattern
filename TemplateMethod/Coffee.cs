using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Coffee : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Add milk in coffee");
        }

        public override void Brew()
        {
            Console.WriteLine("Brew the coffee");
        }

        public override bool IsAddCondiments()
        {
            return true;
        }
    }
}
