using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Radency.TestPoject
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = Order("45 34 24 108 76 58 64 130 80"); // 130 24 34 80 108 45 64 58 76"
            result = Order("    2022 70 123    3344 13 "); // "13 123 2022 70 3344"

        }



        public static string Order(string input)
        {
            var massesArray = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var result = massesArray
                .OrderBy(x => x.Sum(y => int.Parse(y.ToString())))
                .ThenBy(z => z);

            return String.Join(" ", result);
        }



    }

}