using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class CaffeineBeverage
    {
        public void PrepareReceipe()
        {
            BoilWater();
            Brew();
            PourInCup();    
            if(IsAddCondiments())
            {
                AddCondiments();
            }
        }

        private void BoilWater()
        {
            Console.WriteLine("Boil water");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pour in cup");
        }

        public virtual bool IsAddCondiments()
        {
            return true;
        }

        public abstract void Brew();

        public abstract void AddCondiments();
    }
}
