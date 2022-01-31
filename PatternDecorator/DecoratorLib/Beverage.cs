using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLib
{
    public abstract class Beverage
    {
        protected string description = "";
        protected bool milk;
        protected bool soy;
        protected bool mocha;
        protected bool whip;

        public string Cost()
        {
            return milk + " " + soy +" " + mocha + " " + whip;
        }

        public string GetDescription()
        {
            return description;
        }
    }
}
