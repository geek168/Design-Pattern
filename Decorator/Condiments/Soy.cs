using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Soy : CondimentDecorator
    {
        private Beverage Beverage;

        public Soy(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return Beverage.Cost() + 0.5;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + "，Soy";
        }
    }
}
