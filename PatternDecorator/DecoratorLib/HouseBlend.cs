using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLib
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "Домашний кофе ";
        }
        public override double Cost()
        {
            return 0.89;
        }
        public override string GetDescription()
        {
            return description;
        }
    }
}
