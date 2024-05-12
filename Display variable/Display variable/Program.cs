using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "john";
            Console.WriteLine("Hello. "  + name);

            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 6;
            Console.WriteLine(x+y);

            char A = 'A';
            Console.WriteLine(A+x);   

            int a= 5, b = 6, c = 7;
            Console.WriteLine(a+b+c);
        }
    }
}
