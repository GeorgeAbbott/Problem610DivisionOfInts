using System;

namespace Problem610DivisionOfInts
{
    class Program
    {
        static int Divide(int dividend, int divisor)
        {
            int count = 0;
            int timesAdded = 0;

            while (count < dividend)
            {
                count += divisor;
                if ((count <= dividend))
                    timesAdded++;
            }

            return timesAdded;
        }

        static void Main(string[] args)
        {
            // Implement division of two positive integers without using the division,
            // multiplication, or modulus operators. Return the quotient as an integer,
            // ignoring the remainder.

            int dividend;
            int divisor;

            while (true)
            {
                Console.Write("Enter dividend: ");
                dividend = Int32.Parse(Console.ReadLine());

                Console.Write("Enter divisor: ");
                divisor = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"Normal Division => {dividend} / {divisor} = {dividend / divisor}");
                Console.WriteLine($"Divide({dividend}, {divisor}) => {Divide(dividend, divisor)}");
            }


        }
    }
}
