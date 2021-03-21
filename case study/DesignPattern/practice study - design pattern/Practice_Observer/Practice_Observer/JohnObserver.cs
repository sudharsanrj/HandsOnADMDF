using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Observer
{
    class JohnObserver : INotificationObserver
    {

        public string Name { get { return "John"; } }




        public void OnServerDown()
        {

            Console.WriteLine(" server down for "+Name);
        }
    }
}
