using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Armstrong Number
            /*int a, b, r, s = 0;
            Console.WriteLine("Enter a number you want: ");

            a = int.Parse(Console.ReadLine());
            b = a;

            while(b > 0)
            {
                r = b % 10;
                s = (int)(s + Math.Pow(r, 3));

                //s = s*10*r; //reverse and palindrome number
                //s = s + r; //to find out the dudeney number
                b = b / 10;


            }
                //if(Math.Pow(s,3)==a) --> dudeney number

            if(s == a)
            {
                Console.WriteLine("It is a armstrong Number");
            }
            else
            {
                Console.WriteLine("It's not a armstrong number");
            }

            Console.ReadKey();
            */

            //Reverse number

            int a, b, r, s = 0;
            Console.WriteLine("Enter a number you want: ");

            a = int.Parse(Console.ReadLine());

            b = a;

            while (b > 0)
            {
                r = b % 10;

               // s = s* 10 + r; //reverse and palindrome number
                s = s + r; //to find out the dudeney number
                b = b / 10;


            }
            if (Math.Pow(s, 3) == a) // to find out dudeney number
            {
                Console.WriteLine("Dudeney number");
            }
            else
            {
                Console.WriteLine("It's not a dudeney number");
            }

            Console.ReadKey();

        }
    }
}
