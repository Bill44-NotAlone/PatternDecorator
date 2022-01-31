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
        protected double payment;
        public abstract double Cost();

        public string GetDescription()
        {
            return description;
        }
    }
}
