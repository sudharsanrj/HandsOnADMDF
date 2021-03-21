using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediator chatMediator = new ChatMediator();
            IUser u1 = new BasicUser();
            u1.Name = "Arthur";
            IUser u2 = new PremiumUser();
            u2.Name = "Bruce";
            IUser u3 = new BasicUser();
            u3.Name = "Clark";
            chatMediator.AddUser(u1);
            chatMediator.AddUser(u2);
            chatMediator.AddUser(u3);



            chatMediator.SendMessage(u1,"Hello");
            //Console.WriteLine("\n\n***********\n\n");
            //chatMediator.SendMessage(u2, "hii guys");


            Console.ReadLine();
        }
    }
}
