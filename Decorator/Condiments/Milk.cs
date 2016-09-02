using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Milk : CondimentDecorator
    {
        private Beverage Beverage;

        public Milk(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return Beverage.Cost() + 0.9;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + "，Milk";
        }
    }
}
