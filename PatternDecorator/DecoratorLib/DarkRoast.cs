﻿using System;
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
            description = "Коффе с темной обжаркой ";
            payment = 200;
        }
        
        public new double Cost()
        {
            return base.Cost();
        }
    }
}
