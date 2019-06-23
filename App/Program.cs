
using System;
using Classes;
using Classes.Details;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstFractionalNumber = new FractionalNumber(1, 4.0/5);
            var view = new ShowFractionalNumber();
            view.Show(firstFractionalNumber);

            var secondFractionNumber = firstFractionalNumber;

            var resultCompare = firstFractionalNumber.Equals(secondFractionNumber);
            Console.WriteLine($"Result compare is {resultCompare}");
            
            secondFractionNumber.IntegerPart = 4;
            secondFractionNumber.FractionPart = 2.0 / 4;
            
            view.Show(firstFractionalNumber);
            view.Show(secondFractionNumber);
            
            var thirdFractionNumber = new FractionalNumber(secondFractionNumber);
            thirdFractionNumber.IntegerPart = 10;
            
            view.Show(secondFractionNumber);
            view.Show(thirdFractionNumber);
        }
    }
}
