using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class CarClient
    {
        IHeadlight Headlight;
        ITire Tire;


        public CarClient(Factory factory)
        {
            Headlight = factory.makeHeadlight();
            Tire = factory.makeTire();
        }

        public string GetHeadLightDetails()
        {
            return Headlight.GetDetails();
        }

        public string GetTireDetails()
        {
            return Tire.GetDetails();
        }


    }
}
