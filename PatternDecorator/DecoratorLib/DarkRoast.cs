using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLib
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Кофе с темной обжаркой";
        }
        public override double Cost()
        {
            return 0.99;
        }

        public override string GetDescription()
        {
            return description;
        }
    }
}
