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
        protected bool milk = false;
        protected bool soy = false;
        protected bool mocha = false;
        protected bool whip = false;
        protected double payment = 0;
        public double Cost()
        {
            if (milk) payment = 32 + payment;
            if (soy) payment = 78 + payment;
            if (mocha) payment = 45 + payment;
            if (whip) payment = 59 + payment;
            return payment;
        }

        public string GetDescription()
        {
            return description;
        }
        
        public void SetMilk()
        {
            description = description + "молоко ";
            milk = true;
        }

        public void SetSoy()
        {
            description = description + "соя ";
            soy = true;
        }

        public void SetMocha()
        {
            description = description + "мокко ";
            mocha = true;
        }
        public void SetWhip()
        {
            description = description + "взбитые сливки ";
            whip = true;
        }
    }
}
