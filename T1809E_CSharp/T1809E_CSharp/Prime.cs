using System;

namespace T1809E_CSharp
{
    public class Prime
    {
        public static void Main(String[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                if (checkPrime(i))
                {
                    Console.WriteLine(i+" la so nguyen to");
                }
            }
        }

        public static bool checkPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}