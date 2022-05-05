using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_winForms_exceptions.Entities
{
    internal class Fraction
    {
        internal int numerator { get; set; }
        internal int denominator { get; set; }

        public Fraction(string a, string b)
        {
            // if one of the boxes is empty
            if (a == "")
                throw new ArgumentNullException("Numerator", "Input data cannot be empty.");
            if (b == "")
                throw new ArgumentNullException("Denominator", "Input data cannot be empty.");

            // one of the numbers has invalid characters
            if (!int.TryParse(a, out int parsedNum))
            {
                throw new InvalidNumeratorException(a);
            }
            numerator = parsedNum;

            if (!int.TryParse(b, out int parsedDenom))
            {
                throw new InvalidDenominatorException(b);
            }
            denominator = parsedDenom;

            if (denominator == 0)
            {
                throw new DivideByZeroException("Division by zero is invalid. Please enter a valid denominator.");
            }

        }
        public float result()
        {
            return (float)numerator / denominator;
        }
    }
}
