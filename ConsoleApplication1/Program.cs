using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            for (int i = 1; i <= 100; i++)
            {
                array[i - 1] = i;
                Console.Write(array[i - 1]);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}
