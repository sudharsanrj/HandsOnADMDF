using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class DBConn
    {
        private static DBConn instance;
        private DBConn()
        {
            Console.WriteLine("Singleton Instance");
        }
        public static DBConn getInstance()
        {
            if (DBConn.instance == null)
            {
                DBConn.instance = new DBConn();
                
            }
            return DBConn.instance;
        }
        public void PrintDetails(string name)
        {
            Console.WriteLine("Hi " +name);
        }
    }
}

