
using System;

namespace Classes.Details
{
    public struct FractionalNumber : IEquatable<FractionalNumber>
    {
        public int IntegerPart { get; set; }
        
        public double FractionPart { get; set; }

        public FractionalNumber(int integerPart, double fractionPart)
        {
            IntegerPart = integerPart;
            FractionPart = fractionPart;
        }

        public FractionalNumber(FractionalNumber fractionalNumber)
        {
            IntegerPart = fractionalNumber.IntegerPart;
            FractionPart = fractionalNumber.FractionPart;
        }

        public bool Equals(FractionalNumber other)
        {
            return IntegerPart == other.IntegerPart 
                   && Math.Abs(FractionPart - other.FractionPart) < 0.001;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var fractionalNumber = (FractionalNumber) obj;
            return Equals(fractionalNumber);
        }

        public override int GetHashCode()
        {
            return IntegerPart ^ (int)FractionPart;
        }
        
    }
}