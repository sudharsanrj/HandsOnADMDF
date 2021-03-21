﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class PhoneOrderRepair : IOrderRepair
    {
        
        public void ProcessPhoneRepair(string modelName)
        {
            Console.WriteLine(string.Format("{0} repair accepted!", modelName));
        }
    }
}
