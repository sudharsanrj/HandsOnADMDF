using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AudiFactory: Factory
    {
        public IHeadlight makeHeadlight()
        {
            return new AudiHeadlight();
        }

        public ITire makeTire()
        {
            return new AudiTire();
        }
    }
}
