using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Mocha : CondimentDecorator
    {
        private Beverage Beverage;

        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return Beverage.Cost() + 1.2;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + "，Mocha";
        }
    }
}
