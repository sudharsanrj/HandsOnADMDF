﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Observer
{
    public interface INotificationObserver
    {
        string Name { get; }

        void OnServerDown();
    }
}
