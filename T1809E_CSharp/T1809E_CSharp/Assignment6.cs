using System;
using System.Threading;

namespace T1809E_CSharp
{
    public class Assignment6
    {    
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Input n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Thread t1 = new Thread(delegate()
            {
                for (int i = 0; true; i++)
                {
                    for (int j = 0; j < 60; j++)
                    {
                        Console.WriteLine(i.ToString("D2")+
                                          ":"+j.ToString("D2"));
                        Thread.Sleep(1000);
                    }
                }
            });
            
            Thread t2 = new Thread(delegate()
            {
                int x1 = 1, x2 = 1, x3 = 2;
                for (int i = 0; x1+x2 < n; i++)
                {
                    x3 = x1 + x2;
                    x1 = x2;
                    x2 = x3;
                    Console.WriteLine("Fibo: " + x3);
                    Thread.Sleep(500);
                }
            });
            t1.IsBackground = true;
            t1.Start();
            t2.Start();
        }
    }
}