using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    public struct Fraction
    {
        public Fraction(long numerator, long denominator)
            : this()
        {
            long gcd = GreatestCommonDivisor(numerator, denominator);
            this.Numerator = numerator / gcd;
            this.Denominator = denominator / gcd;

            if (this.denominator < 0)
            {
                this.Numerator = -numerator;
                this.Denominator = -denominator;
            }
        }

        private long numerator;
        private long denominator;
        private double fractionResult;

        public long Numerator
        {
            get { return this.numerator*4; }
            set { this.numerator = value; }
        }

        public long Denominator
        {
            get { return this.denominator*4; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be 0.");
                }
                this.denominator = value;
            }
        }

        public double FractionResult
        {
            get
            {
                fractionResult = (double)this.Numerator/this.Denominator;
                return this.fractionResult;
            }
            private set { }

        }


        //overloading / methods
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            long num = f1.numerator*f2.denominator +
                       f2.numerator*f1.denominator;
            long denom = f1.denominator*f2.denominator;
            return new Fraction(num,denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long num = f1.numerator * f2.denominator -
                f2.numerator * f1.denominator;
            long denom = f1.denominator * f2.denominator;

            return new Fraction(num, denom);
        }

        private static long GreatestCommonDivisor(
        long firstNumber, long secondNumber)
        {
            firstNumber = Math.Abs(firstNumber);
            secondNumber = Math.Abs(secondNumber);

            while (firstNumber > 0)
            {
                long newNumber = secondNumber % firstNumber;
                secondNumber = firstNumber;
                firstNumber = newNumber;
            }

            return secondNumber;
        }

        public override string ToString()
        {
            return String.Format("{0}",
                 this.FractionResult);
        }
    }
}
