using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ModelDuck : Duck
    {
        public ModelDuck(IFlyable fly, IQuackable quack) : base(fly, quack)
        {
             
        }

        public override void Display()
        {
            Console.WriteLine("This is model duck's display is yellow!");
        }
    }
}
