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

            int n = 0;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine($"\nEvaluating of {n}!\nBy using ordinary method:");
            var F = Factr(n);//Обчислення факторіала звичайним методом (171! вже перевищує розмірність double)
            Console.WriteLine(F);

            
            Console.WriteLine("\nBy using method of long arithmetic:");
            LongFactr(n);


            Console.ReadKey();
        }

        public static double Factr(int n)
        {
            double result = 1.0;
            for (int i = 1; i <=n; i++)
            {
                result = result * i;
            }
            return result;
        }

        public static void LongFactr(int n)
        {
            List<Data> factorial = new List<Data>();

            int least = 1;
            var first = new Data();
            first.Set(1, 0);
            factorial.Add(first);

            for (int j = 1; j < n; j++)
            {
                int prev = 0;
                for (int i = 0; i < factorial.Count; i++)
                {
                    least = factorial[i].Set(j + 1, prev);
                    prev = least;
                }
                while (least >= 1)
                {
                    var temp = new Data();
                    least = temp.Set(0, least);
                    factorial.Add(temp);
                }
            }
            for (int i = factorial.Count - 1; i >= 0; i--)
            {
                if (i == factorial.Count - 1) { factorial[i].Show(true); }
                else { factorial[i].Show(false); }
            }
            Console.WriteLine($"\nNumber of digits: {2*factorial.Count}");
        }
    }
}
