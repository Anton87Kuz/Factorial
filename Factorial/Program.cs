using Factorial.Factorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            var r = new Data(2);
            
            int n = 0;
            int.TryParse(Console.ReadLine(), out n);

            Console.WriteLine($"\nEvaluating of {n}!\nBy using ordinary method:");

            var F = Factr(n);
            Console.WriteLine(F);

            
            Console.WriteLine("\nBy using method of long arithmetic:");
            LongFactr(n);


            Console.ReadKey();
        }

        public static double Factr(int n)
        {
            double result = 1.0;
            for (int i = 1; i <n; i++)
            {
                result *=  i+1;
            }
            return result;
        }

        public static void LongFactr(int n)
        {
            LongNumber factorial = new LongNumber(1);

            for (int j = 1; j < n; j++)
            {
                factorial.MultOnInt(j+1);
            }
            factorial.Display();
            Console.WriteLine($"\nNumber of digits: {factorial.NumberOfDigits()}");
        }
    }
}
