using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLib
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Коффе без кофеина ";
            payment = 100;
        }
        
        public new double Cost()
        {
            return base.Cost();
        }
    }
}
