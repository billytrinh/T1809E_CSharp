using System;
using System.Threading;

namespace T1809E_CSharp
{
    public class Session6
    {
        
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(SayHello2);
            t1.Start("abc xyz");
           // Session6 s = new Session6();
          //  Thread t2 = new Thread(s.SayHello3);
            Thread t2 = new Thread(new Session6().SayHello3);
            t2.Start();
            
            Thread t3 = new Thread(
                delegate()
                    {
                        Console.WriteLine("thread t3 ...");
                    }
            );
            t3.Start();
            int aaaaa = 28383;
            Thread t4 = new Thread(
                    delegate(object o) { 
                        Console.WriteLine(aaaaa+ "thread t4.....");
                     }
                );
            t4.Start("tham so can truyen");
            
            SayHello();
        }

        public static void SayHello()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i+" - hello world");
                Thread.Sleep(200);
            }
        }
        public static void SayHello2(object o)
        {
            string s = (string) o;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i+" - hello world2 "+s);
                Thread.Sleep(200);
            }
        }

        public void SayHello3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i+" - hello world3");
                Thread.Sleep(200);
            }
        }
    }
}