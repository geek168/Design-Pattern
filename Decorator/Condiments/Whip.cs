using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Whip : CondimentDecorator
    {
        private Beverage Beverage;

        public Whip(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return Beverage.Cost() + 0.2;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + "，Whip";
        }
    }
}
