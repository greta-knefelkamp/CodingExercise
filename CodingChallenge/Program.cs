using static codingChallenge.exampleClass;

namespace codingChallenge
{
    class Program
    {
        static void Main()
        {
            // creating examples and printing the results
            List<int> intsToCompare = new() { 1, 300, 2, 6, 12, 9, 231, 500, 3 };
            int comparisonValue = 5;
            Dictionary<string, int> aboveBelowCounts = aboveBelow(intsToCompare, comparisonValue);
            Console.WriteLine("#################################");
            Console.WriteLine($"Number of integers in list above {comparisonValue}: {aboveBelowCounts["above"]}");
            Console.WriteLine($"Number of integers in list below {comparisonValue}: {aboveBelowCounts["below"]}");
            Console.WriteLine("#################################");
            Console.WriteLine();

            string originalString = "Hello, World!";
            Console.WriteLine("#################################");
            Console.WriteLine($"Original string: {originalString}");
            uint rotationAmount = 6;
            string rotatedString = stringRotation(originalString, rotationAmount);
            Console.WriteLine($"String after rotating to the right by {rotationAmount}: {rotatedString}");
            Console.WriteLine("#################################");
        }
    }
}