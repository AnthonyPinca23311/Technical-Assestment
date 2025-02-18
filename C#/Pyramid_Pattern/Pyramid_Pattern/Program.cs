using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of levels: ");
            int levels = int.Parse(Console.ReadLine());
            PrintPyramid(levels);
        }

        static void PrintPyramid(int levels)
        {
            for (int i = 1; i <= levels; i++)
            {
                Console.Write(new string(' ', levels - i));
                Console.WriteLine(new string('*', i * 2 - 1));
            }
        }
    }
}
