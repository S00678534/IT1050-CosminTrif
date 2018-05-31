using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LAB01
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1;
            int number2;
            int sum;

            Console.Write("Enter First Integer to Add:  ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Integer to Add:  ");
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine("Sum is {0}", sum);
            Console.ReadLine();


            int x = 6;
            int y = 8;
            int z = 43;
            int xyz;


            xyz = ((x + y) * (z + 10));

            Console.WriteLine("Equation equals " + xyz);
            Console.ReadLine();

            Console.WriteLine("Output 1:");
            Console.WriteLine("Hello\tWorld");

            Console.WriteLine("Output 2:");
            Console.WriteLine("Hello\nWorld");

            Console.WriteLine("Output 3:");
            Console.WriteLine("\"Hello World!\"");

            Console.WriteLine("Output 4:");
            Console.WriteLine(@"Hello\World");

            Console.WriteLine("Output 5:");
            Console.WriteLine(@"Hello\""\\\""World!\");

        }
    }
}