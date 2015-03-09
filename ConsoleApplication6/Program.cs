using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Name: ");
            string n = Console.ReadLine();
            Console.Write("Age: ");
            byte age = Convert.ToByte( Console.ReadLine());
            Man m1 = new Man(n, age);
            m1.HappyBirthday();
            m1.HappyBirthday();
            Console.WriteLine(m1.name +" is "+ m1.age + " years old");

            Man m2 = new Man("Alex", 30);
           
        }
    }
}
