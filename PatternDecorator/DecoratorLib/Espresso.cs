using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLib
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Экспрессо ";
        }
        public override double Cost()
        {
            return 1.99;
        }
        public override string GetDescription()
        {
            return description;
        }
    }
}
