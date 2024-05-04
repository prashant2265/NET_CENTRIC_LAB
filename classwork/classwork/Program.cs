using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classwork
{
    class Test<T>
    {
        T[] t= new T[5];
        int count = 0;
        public void addItem(T item)
        {
            if (count < 5)
            {
                t[count] = item;
                count++;

            }
            else
            {
                Console.WriteLine("overflow exist");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
