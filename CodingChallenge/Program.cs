using static codingChallenge.exampleClass;

namespace codingChallenge
{
    class Program
    {
        static void Main()
        {
            // creating examples and printing the results
            List<int> intsToCompare = new() { 1, 5, 2, 1, 10 };
            int comparisonValue = 6;
            Dictionary<string, int> aboveBelowCounts = aboveBelow(intsToCompare, comparisonValue);
            Console.WriteLine("#################################");
            Console.WriteLine($"Number of integers in list above {comparisonValue}: {aboveBelowCounts["above"]}");
            Console.WriteLine($"Number of integers in list below {comparisonValue}: {aboveBelowCounts["below"]}");
            Console.WriteLine("#################################");
            Console.WriteLine();

            string originalString = "MyString";
            Console.WriteLine("#################################");
            Console.WriteLine($"Original string: {originalString}");
            uint rotationAmount = 2;
            string rotatedString = stringRotation(originalString, rotationAmount);
            Console.WriteLine($"String after rotating to the right by {rotationAmount}: {rotatedString}");
            Console.WriteLine("#################################");
        }
    }
}