using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, factorial;
            Console.WriteLine("Type number to find the factorial...");
            number = int.Parse(Console.ReadLine());
            factorial = FindFactorial(number);
            Console.WriteLine(factorial);
            Console.ReadLine();
        }

        public static int FindFactorial(int number)
        {
            if (number == 1)
            {
                return number;
            }

            return number * FindFactorial(number - 1);
        }
    }
}
