using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak03
{
    internal class Fraction
    {
        private const char Delimiter = '/';

        public int Numerator { get; }

        private int denominator;

        public int Denominator
        {
            get => denominator;
           private set
            {
                if (value==0)
                {
                    throw new Exception("Denominator must not be zero!");
                }
                denominator = value;
            }
        }

        public Fraction(int numerator, int denominator)
        {
            if (denominator<0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
            int greatestCommonDivisor = GreatestCommonDivisor(numerator, denominator);
            Numerator=numerator/greatestCommonDivisor;
            Denominator=denominator/greatestCommonDivisor;

        }

        private int GreatestCommonDivisor(int numerator, int denominator)
        {
            int min =Math.Min(Math.Abs(numerator), Math.Abs(denominator));
            for (int i = min; i >= 2; i--)
            {
                if (numerator%i==0&&denominator%i==0)
                {
                    return i;
                }
               
            }
            return 1;
        }

        public Fraction Multiply(Fraction other)=>new Fraction (Numerator*other.Numerator, Denominator*other.Denominator);
        public Fraction Divide (Fraction other)=> new Fraction (Numerator*other.Denominator, Denominator*other.Numerator);
        public Fraction Add(Fraction other) => new Fraction (Numerator*other.Denominator+Denominator*other.Numerator, Denominator*other.Denominator);
        public Fraction Subtract(Fraction other) => new Fraction (Numerator*other.Denominator-Denominator*other.Numerator, Denominator*other.Denominator);


        public override string ToString() => Denominator == 1 || Numerator == 0 ? Numerator.ToString() : $"{Numerator}{Delimiter}{Denominator}";

        public static Fraction Parse(string s)
        {
            string[] details = s.Split(Delimiter);
            if (details.Length>2)
            {
                return null;
            }

            if (!int.TryParse(details[0], out int numerator))
            {
                return null;
            }

            int denominator = 1;

            if (detalis.Length == 2 && !int.TryParse(details[1], out denominator))
            {
                return null;
            }
            return new Fraction (numerator, denominator);
        }
        
    }
}
