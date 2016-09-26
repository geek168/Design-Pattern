using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Tea : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Add sugar in tea");
        }

        public override void Brew()
        {
            Console.WriteLine("Steep the tea");
        }

        public override bool IsAddCondiments()
        {
            return false;
        }
    }
}
