namespace codingChallenge
{
    public class exampleClass
    {
        /// <summary>
        /// Compares the numbers in an unsorted list of integers to a given comparison value
        /// </summary>
        /// <param name="unsortedIntegers"></param>
        /// <param name="comparisonInteger"></param>
        /// <returns>Returns a dictionary with "above"/"below" keys storing the counts
        /// of integers from the list that were above/below the comparison value</returns>
        public static Dictionary<string, int> aboveBelow(List<int> unsortedIntegers, int comparisonInteger)
        {
            return new Dictionary<string, int>
            {
                { "above", unsortedIntegers.Where(x => x > comparisonInteger).Count() },
                { "below", unsortedIntegers.Where(x => x < comparisonInteger).Count() }
            };
        }

        /// <summary>
        /// Takes a string and rotates it by a given amount of characters
        /// </summary>
        /// <param name="stringToRotate"></param>
        /// <param name="positiveInteger"></param>
        /// <returns>A new rotated string with the overflow from the original string at the beginning</returns>
        public static string stringRotation(string stringToRotate, uint positiveInteger)
        {
            string rotatedString = stringToRotate;
            int stringLength = stringToRotate.Length;

            if (stringLength > 0 && positiveInteger > 0)
            {
                string originalFirstHalf = stringToRotate[..(int)(stringLength - positiveInteger % stringLength)];
                string originalSecondHalf = stringToRotate[(int)(stringLength - positiveInteger % stringLength)..];
                rotatedString = originalSecondHalf + originalFirstHalf;
            }

            return rotatedString;
        }
    }
}
