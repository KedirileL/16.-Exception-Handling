using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)

        {
            try
            {
                Console.WriteLine("Enter your first number ");
                double number1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your second number ");
                double number2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Your first number divided by your second number = ");
                Console.WriteLine(number1 / number2);

                
            }
            catch 
            { 
                Console.WriteLine("Error: one of the entered values is not a number!");
            }

            //freeze console
            Console.ReadLine();
        }
    }
}
