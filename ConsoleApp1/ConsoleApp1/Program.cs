
/*WAP to find greatest numbers among any three numbers*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Input the 1st number :");  
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 2nd number :");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 3rd number :");
            num3 = int.Parse(Console.ReadLine());


            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($" {num1} is greatest among three numbers.");


            }else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine($"{num2} is greatest among three numbers.");

            }
            else if(num3 > num1 && num3 > num2)
            {
                Console.WriteLine($" {num3} number is greatest among three numbers.");
            }
            else
            {
                Console.WriteLine($"All the three numbers are equal.");
            }

            Console.ReadKey();


        }
    }
}
