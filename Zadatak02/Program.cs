using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ivo", "Ivic")
            {
                YearOfStudy=2,
                Average=3.9
            };
            Console.WriteLine(student);
            student = new Student();
            Console.WriteLine(student);
        }
    }
}
