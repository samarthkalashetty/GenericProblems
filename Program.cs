using System;

class UC3
{
    static void Main(string[] args)
    {
        for (int testCase = 1; testCase <= 3; testCase++)
        {
            Console.WriteLine($"Test Case {testCase}");
            string[] words = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter String {i + 1}: ");
                words[i] = Console.ReadLine();
            }

            string max = FindMaximum(words);
            Console.WriteLine($"Maximum (lexicographically) among the entered strings: {max}\n");
        }
    }

    static string FindMaximum(string[] values)
    {
        string max = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (string.Compare(values[i], max) > 0)
            {
                max = values[i];
            }
        }

        return max;
    }
}