using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak02
{
     class Student
    {
        public string Name { get; set; }
        public string  Surname { get; set; }
        public int YearOfStudy { get; set; }
        public double Average { get; set; }

        public Student():this("Pero", "Peric")
        {

        }
        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"Student: {Name} {Surname}, Year of study: {YearOfStudy}, Average score: {Average}";
        }
    }
}
