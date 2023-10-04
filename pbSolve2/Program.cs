using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbSolve2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = Convert.ToInt32(-1);
            int numberTwo = Convert.ToInt32(4);
            int numberThree = Convert.ToInt32(6);

            int total = numberOne + numberTwo * numberThree;
            Console.WriteLine("Total:" + total);

            int first = Convert.ToInt32(35);
            int second= Convert.ToInt32(5);
            int third = Convert.ToInt32(7);

            int output = ((first + second) % third);


            Console.WriteLine(output);


            Console.WriteLine(14 + (-4 * 6)/11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            Console.ReadKey();
        }
    }
}
