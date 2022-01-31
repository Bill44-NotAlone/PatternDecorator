using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLib
{
    public class Soy : CondimentDecorator
    {
        private Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.15;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " соей";
        }
    }
}
