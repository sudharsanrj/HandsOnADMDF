using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConn instance = DBConn.getInstance();
            DBConn instance1 = DBConn.getInstance();
            instance.PrintDetails("Bruce");
            instance1.PrintDetails("Barry");
            Console.WriteLine(instance.GetHashCode());
            Console.WriteLine(instance1.GetHashCode());     
            Console.ReadLine();
        }
    }
}
