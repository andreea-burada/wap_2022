using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_winForms_exceptions.Entities
{
    internal class InvalidNumeratorException : Exception
    {
        public string invalidNumerator { get; set; }

        // ctor
        public InvalidNumeratorException(string invalid_numerator)
        {
            invalidNumerator = invalid_numerator;
        }

        public override string Message
        {
            get { return "Numerator «" + invalidNumerator + "» is invalid. Only integers are allowed."; }
        }
    }

    internal class InvalidDenominatorException : Exception
    {
        public string invalidDenominator { get; set; }

        // ctor
        public InvalidDenominatorException(string invalid_denominator)
        {
            invalidDenominator = invalid_denominator;
        }

        public override string Message
        {
            get { return "Denominator «" + invalidDenominator + "» is invalid. Only integers are allowed."; }
        }
    }
}
