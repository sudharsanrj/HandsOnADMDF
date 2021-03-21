﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MercedesHeadlight : IHeadlight
    {
        public string GetDetails()
        {
            return "   Headlight - Manufacturered by : Mercedes";
        }
    }
}
