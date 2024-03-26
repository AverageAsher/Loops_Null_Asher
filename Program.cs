namespace Loops_Null_Asher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test the space count function
            string testString = "Hello world! This is a test string.";
            int spaceCount = CountSpaces(testString);
            Console.WriteLine($"String: \"{testString}\"");
            Console.WriteLine($"Number of spaces: {spaceCount}");

            // Test the digit sum function
            long testNumber = 123456789;
            long digitSum = CalculateDigitSum(testNumber);
            Console.WriteLine($"Number: {testNumber}");
            Console.WriteLine($"Sum of digits: {digitSum}");
        }

        static int CountSpaces(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    count++;
                }
            }
            return count;
        }

        static long CalculateDigitSum(long number)
        {
            long sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
