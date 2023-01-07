using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomework
{
    public class NewClass
    {
        public string name;

        public int age;
        private string v;

        public NewClass()
        {
            age = 1;
            name= "Mukik";
        }

        public NewClass(string n)
        {
            age = 31;
            name = n;
        }

        public NewClass(int a, string n)
        {
            age = a;
            name = n;
        }

        public void Print()
        {
            Console.WriteLine($"{age} {name}");
        }

        public int GetAge(int a)
        {
            int resoult =a-15;
            return resoult;
        }
    }



}
