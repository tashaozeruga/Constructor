using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Man
    {

        public string name;
        public byte age;
        public Man(string _name, byte _age)
        {
            name = _name;
            age =  _age;
        }
        public void HappyBirthday()
        {
            Console.WriteLine ("Happy Birthday " + name);
            age++;
        }
    }
}
