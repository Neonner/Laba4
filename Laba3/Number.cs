using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


namespace Laba3
{
    public class Number
    {
        public double Denominator1;
        public double Numerator1;
        public double Denominator2;
        public double Numerator2;
        public Random rnd = new Random();
        public void RandomValue() 
        { 
            Denominator1 = rnd.Next(1 , 11);
            Numerator1 = rnd.Next(11 , 21);
            Denominator2 = rnd.Next(1, 11);
            Numerator2 = rnd.Next(11, 21);
        }

        public override string ToString()
        {
            return $"Denominator is {Denominator1}, Numerator is {Numerator1}" + "\n" +
                   $"second Denominator is {Denominator2}, second Numerator is {Numerator2}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if(obj is Number number)
            return Denominator1 == number.Denominator1 && Numerator1 == number.Numerator1 && Denominator2 == number.Denominator2 && Numerator2 == number.Numerator2;
            return false;
        }
    }

    public class Sign : Number
    { 
        public void RandomSign()
        {
           
            int sign = rnd.Next(1, 4);
            if (sign == 1)
            {
                Denominator1 = -Denominator1;
            }
            else if (sign == 2)
            {
                Denominator2 = -Denominator2;
            }
            else if(sign == 3)
            {
                Denominator1 = -Denominator1;
                Denominator2 = -Denominator2;
            }
        }
        public override string ToString()
        {
            return $"Denominator is {Denominator1}, Numerator is {Numerator1}" + "\n" +
                   $"second Denominator is {Denominator2}, second Numerator is {Numerator2}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is Sign sign)
                return Denominator1 == sign.Denominator1 && Numerator1 == sign.Numerator1 && Denominator2 == sign.Denominator2 && Numerator2 == sign.Numerator2;
            return false;
        }
    }

    public class SimpleFraction : Sign
    {
        public double fraction1;
        public double fraction2;

        public void CreateFraction()
        {
            fraction1 = Denominator1 / Numerator1;
            fraction2 = Denominator2 / Numerator2;
        }
        public double Sum()
        {
           return fraction1 +  fraction2;
        }
        public double Subtraction()
        {
            return fraction1 - fraction2;
        }
        public double Multiplication()
        {
            return fraction1 * fraction2;
        }
        public double Division()
        {
            return fraction1 / fraction2;
        }

        public override string ToString()
        {
            return $"First Fraction = {fraction1}, Second Fraction {fraction2}\n" +
                  $"Amount = {Sum()}, Subtraction = {Subtraction()}, Multiplication = {Multiplication()}, Division = {Division()} "; 
                  
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is SimpleFraction fract)
                return Denominator1 == fract.Denominator1 && Numerator1 == fract.Numerator1 && Denominator2 == fract.Denominator2 && Numerator2 == fract.Numerator2 &&
                         fraction1 == fract.fraction1 && fraction2 == fract.fraction2;
            return false;
        }

    }

}
