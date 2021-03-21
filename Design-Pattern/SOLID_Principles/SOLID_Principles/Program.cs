using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Service: Order or Repair");
            string processOption = Console.ReadLine().ToLower().Trim();
            string productDetail;
            switch(processOption)
            {
                case "order":

                    Console.WriteLine("Please provide the phone model name");
                    productDetail = Console.ReadLine().Trim();
                    ProcessPhoneOrder P = new ProcessPhoneOrder();
                    P.ProcessOrder(productDetail);
                    break;
                case "repair":
                    AccessoryRepair accessory = new AccessoryRepair(); 
                    PhoneOrderRepair phoneOrderRepair = new PhoneOrderRepair();

                    Console.WriteLine("choose: phone or accessory");
                    string productType = Console.ReadLine().ToLower();
                    if(productType.Equals("phone"))
                    {
                        Console.WriteLine("Please provide the phone model name");
                        productDetail = Console.ReadLine().Trim();
                        phoneOrderRepair.ProcessPhoneRepair(productDetail);
                    }
                    else    
                    {
                        Console.WriteLine("Please provide the accessory detail");
                        productDetail = Console.ReadLine().Trim();
                        accessory.ProcessAccessoryRepair(productDetail);
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine("Thanks for choosing us. Have a great day.");
            Console.ReadLine();
        }
    }
}
