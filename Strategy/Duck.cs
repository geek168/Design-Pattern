using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Duck
    {
        public Duck(IFlyable fly, IQuackable quack)
        {
            IFlyable = fly;
            IQuackable = quack;
        }

        private IFlyable IFlyable;
        private IQuackable IQuackable;

        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("All duck can swim!");
        }

        public void PerformFly()
        {
            IFlyable.Fly();
        }

        public void PerformQuack()
        {
            IQuackable.Quack();
        }
    }
}
