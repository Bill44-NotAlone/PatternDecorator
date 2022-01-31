using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLib
{
    public class Mocha : CondimentDecorator
    {
        private Beverage beverage;
        
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.2;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " мокко";
        }
    }
}
