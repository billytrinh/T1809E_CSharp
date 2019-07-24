using System;

namespace T1809E_CSharp
{
    public class Student
    {
        public string name;
        public int age;

        public Student()
        {
            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
        }

        public Student(int age)
        {
            name = Console.ReadLine();
            this.age = age;
        }
        
        
        public void ShowInfo()
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
        }

        public void ShowInfo(int x)
        {
            Console.WriteLine(x+" Name: "+name);
            Console.WriteLine(x+" Age: "+age);
        }
    }
}