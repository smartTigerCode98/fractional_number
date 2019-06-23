using System;
using Classes.Interfaces;

namespace Classes.Details
{
    public class ShowFractionalNumber : IShowFractionalNumber
    {
        public void Show(FractionalNumber fractionalNumber)
        {
            Console.WriteLine($"Integer part of number is {fractionalNumber.IntegerPart}");
            Console.WriteLine($"Fraction part of number is {fractionalNumber.FractionPart}");
        }
    }
}