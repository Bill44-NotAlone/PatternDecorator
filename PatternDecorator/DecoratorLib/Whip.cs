﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLib
{
    public class Whip : CondimentDecorator
    {
        private Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.1;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " взбитыми сливками";
        }
    }
}
