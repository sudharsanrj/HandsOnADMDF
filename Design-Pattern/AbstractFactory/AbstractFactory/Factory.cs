﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    interface Factory
    {
        IHeadlight makeHeadlight();
        ITire makeTire();

    }
}
