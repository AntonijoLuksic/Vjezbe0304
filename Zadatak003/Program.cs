using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = ReadFraction("Please insert first fraction: ");
            Fraction f2 = ReadFraction("Please insert second fraction: ");

            Console.WriteLine($"{f1} + {f2}={f1.Add(f2)}");
            Console.WriteLine($"{f1} - {f2}={f1.Subtract(f2)}");
            Console.WriteLine($"{f1} * {f2}={f1.Multiply(f2)}");
            Console.WriteLine($"{f1} / {f2}={f1.Divide(f2)}");
        }

        private static Fraction ReadFraction(string message)
        {
            Fraction f;
            do
            {
                Console.WriteLine(message);
                f=Fraction.Parse(Console.ReadLine());
            } while (f==null);
            return f;
        }
    }
}
