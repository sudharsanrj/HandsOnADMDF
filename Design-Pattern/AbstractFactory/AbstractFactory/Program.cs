using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //IMobilePhone nokiaMobilePhone = new Nokia();
            //MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);
            Factory audiFac = new AudiFactory();
            CarClient audiClient = new CarClient(audiFac);

            Console.WriteLine("********* AUDI**********");
            Console.WriteLine(audiClient.GetHeadLightDetails());
            Console.WriteLine(audiClient.GetTireDetails());


            Factory mercedesFac = new MercedesFactory();
            CarClient mercedesClient = new CarClient(mercedesFac);


            Console.WriteLine("*********MERCEDES**********");
            Console.WriteLine(mercedesClient.GetHeadLightDetails());
            Console.WriteLine(mercedesClient.GetTireDetails());

            Console.ReadKey();
        }
    }
}
