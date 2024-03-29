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

        // Function to count spaces in a string
        static int CountSpaces(string input)
        {
            int count = 0;
            // Loop through each character in the input string
            foreach (char c in input)
            {
                // Check if the character is a space
                if (c == ' ')
                {
                    // Increment the count if it's a space
                    count++;
                }
            }
            // Return the total count of spaces
            return count;
        }

        // Function to calculate the sum of digits in a number
        static long CalculateDigitSum(long number)
        {
            long sum = 0;
            // Loop until the number becomes zero
            while (number > 0)
            {
                // Add the last digit of the number to the sum
                sum += number % 10;
                // Remove the last digit from the number
                number /= 10;
            }
            // Return the total sum of digits
            return sum;
        }

    }

}

