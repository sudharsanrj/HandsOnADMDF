using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AbstractFac
{
    public enum Product 
    {
        ElectronicProducts,Toys,Furniture
    }
    public enum Channel 
    {
        ECommerceWebsite,TeleCallerAgents
    }
    class Program
    {
        static void Main(string[] args)
        {
            Factory fact = new ConcreteFactory();
            Client client = new Client(fact);
            client.MakeElectronics(Channel.ECommerceWebsite);
            client.MakeFuniture(Channel.TeleCallerAgents);
            client.MakeElectronics(Channel.TeleCallerAgents);
            client.MakeToys(Channel.ECommerceWebsite);
            Console.ReadKey();
        }
    }
}
