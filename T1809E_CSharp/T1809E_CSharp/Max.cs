using System;
using System.Collections.Generic;

namespace T1809E_CSharp
{
    public class Max
    {
        public static void Main(String[] args)
        {
            List<int> intArr = new List<int>();
            
            Console.WriteLine("Nhập 10 số:");
            for (int i = 0; i < 10; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                intArr.Add(x); 
            }

            int max = intArr[0];

            foreach (int i in intArr)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            Console.WriteLine("Max = "+max);

        }
    }
}