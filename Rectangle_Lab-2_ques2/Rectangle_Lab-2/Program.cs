using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Lab_2
{
    internal class Program
    {
        public class Rectangle
        {
            public int length, breadth;
            public Rectangle()
            {
                length = 0;
                breadth = 0;
            }

            public Rectangle(int length, int breadth)
            {
                this.length = length;
                this.breadth = breadth;
                int a;
                a = length * breadth;
                Console.WriteLine($"The area of Rectangle is:{a} " );
            }
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Rectangle r2 = new Rectangle(5,7);
            Console.ReadKey();
        }
    }
}
