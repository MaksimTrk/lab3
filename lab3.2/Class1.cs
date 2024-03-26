using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._2
{
    internal class ComplexNumber
    {
        private double realPart;
        private double imaginaryPart;

        public ComplexNumber(double real, double imaginary)
        {
            realPart = real;
            imaginaryPart = imaginary;
        }
        public ComplexNumber()
        {
            // Дефолтний конструктор для десеріалізації
        }

        public double RealPart
        {
            get { return realPart; }
            set { realPart = value; }
        }

        public double ImaginaryPart
        {
            get { return imaginaryPart; }
            set { imaginaryPart = value; }
        }

        public ComplexNumber Add(ComplexNumber num)
        {
            return new ComplexNumber(realPart + num.realPart, imaginaryPart + num.imaginaryPart);
        }

        public ComplexNumber Subtract(ComplexNumber num)
        {
            return new ComplexNumber(realPart - num.realPart, imaginaryPart - num.imaginaryPart);
        }

        public ComplexNumber Multiply(ComplexNumber num)
        {
            return new ComplexNumber((realPart * num.realPart) - (imaginaryPart * num.imaginaryPart),
                (realPart * num.imaginaryPart) + (imaginaryPart * num.realPart));
        }

        public override string ToString()
        {
            return $"{realPart} + {imaginaryPart}i";
        }
    }
}
