using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AudiTire:ITire
    {
        public string GetDetails()
        {
            return "   Tire - Manufacturered by : Audi";
        }
    }
}
