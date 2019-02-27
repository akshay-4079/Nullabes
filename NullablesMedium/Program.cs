using System;

namespace CalculatorApplication
{
    class Nullables
    {
        static void Main(string[] args)
        {
            NullableCompare();
            Helper();

        }

        private static void Helper()
        {
            int? i = null;
            int j = 10;

            if (Nullable.Compare<int>(i, j) < 0)
                Console.WriteLine("i < j");
            else if (Nullable.Compare<int>(i, j) > 0)
                Console.WriteLine("i > j");
            else
                Console.WriteLine("i = j");
        }

        private static void NullableCompare()
        {
            int? i = null;
            int j = 10;


            if (i < j)
                Console.WriteLine("i < j");
            else if (i > 10)
                Console.WriteLine("i > j");
            else if (i == 10)
                Console.WriteLine("i == j");
            else
                Console.WriteLine("Could not compare");
        }
    }
}