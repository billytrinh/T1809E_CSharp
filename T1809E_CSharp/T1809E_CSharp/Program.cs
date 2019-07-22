using System;
using System.Collections.Generic;

namespace T1809E_CSharp
{
    class Program123
    {
        public static int age;
        public int year;
        
        public const int day = 7;
        
        static void Main(string[] args)
        {
            int x;
            string a;
            a = Console.ReadLine();
            x = Convert.ToInt32(Console.ReadLine());
            double y;
            y = Convert.ToDouble(Console.ReadLine());
            
            if (x >= 10)
            {
                Console.WriteLine(x+" >= 10");
            }
            else
            {
                Console.WriteLine(x+" < 10");
            }
            Console.WriteLine(a);
            
            List<int> intArr = new List<int>();
            
            intArr.Add(2);
            intArr.Add(3);
            intArr.Add(4);
            
            List<string> strArr = new List<string>();
            strArr.Add("hello");
            strArr.Add("world");
            strArr.Add("everyone");

            foreach (string str in strArr)
            {
                Console.WriteLine(str);
            }
        }
    }
}