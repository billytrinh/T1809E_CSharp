using System;
using System.Collections.Generic;

namespace T1809E_CSharp
{
    public class Session8 <E>
    {
        public E val_1;
        public E val_2;
    }

    public class PhoneNumber<K,V>
    {
        public K name;
        public V phone;
        /*
         *  K : key
         * V : value
         * E : element
         * N : number
         */

        public void ShowParam<T>(T x) where T:Human
        {
            Console.WriteLine(x);
        }
    }

    public class Human
    {
        public int age;
    }

    public class Asia : Human
    {
        
    }

    public class Generic<E> where E:Human
    {
        public E hm;

        public void ShowInfo()
        {
            Console.WriteLine(hm.age);
        }
    }

    public class Session8Main
    {
        public static void Main(string[] args)
        {
            Session8<int> ss1 = new Session8<int>();
            Session8<string> ss2 = new Session8<string>();

            ss1.val_1 = 188;
            ss1.val_2 = 12;

            ss2.val_1 = "hello";
            ss2.val_2 = "world";
            PhoneNumber<string,string> p1 = new PhoneNumber<string, string>();
            PhoneNumber<string,List<string>> p2 = new PhoneNumber<string, List<string>>();
            
//            p2.ShowParam(6);
//            p2.ShowParam("abc xyz");
            List<int> arr = new List<int>();
            
            Generic<Human> g1 = new Generic<Human>();
            Generic<Asia> g2 = new Generic<Asia>();
        }
    }
}