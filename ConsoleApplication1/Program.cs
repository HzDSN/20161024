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
            int i, j;
            int[,] array = new int[15, 15];
            array[1, 1] = array[1, 2] = 1;
            Console.WriteLine(1);
            Console.WriteLine("1 1");
            for (i = 2; i <= 10; i++)
            {
                for (j = 1; j <= i + 1; j++)
                {
                    if (j == 1)
                    {
                        array[i, j] = 1;
                        Console.Write("1");
                    }
                    else
                    {
                        array[i, j] = array[i - 1, j] + array[i - 1, j - 1];
                        Console.Write(array[i, j]);
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
