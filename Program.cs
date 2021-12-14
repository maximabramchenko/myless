using System;

namespace ConsoleApp3
{

    class Max
    {
        string name;
        int age;

        public Max() { name = "Empty";age = 18; }
        public Max(string n) { name = n;age = 18; }
        public Max(string n, int a) { name = n;age = a; }

        public void Print()
        {
            Console.WriteLine($"Name:{name} Age:{age}");
        
        }
    
    
    
    
    }


    class Program
    {
        static void Main(string[] args)
        {

            string a = "Ivan";
            int b = 56;

            Max mix = new Max("mix", 18);
            Console.WriteLine("Hello World!");

            Max ivan = new Max(a, b);

            Max boo = new Max("Boo");
            boo.Print();

            Max poo = new Max();
            poo.Print();


        }
    }
}
