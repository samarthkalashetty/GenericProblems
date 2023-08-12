using System;

class UC2
{
    static void Main(string[] args)
    {
        for (int testCase = 1; testCase <= 3; testCase++)
        {
            Console.WriteLine($"Test Case {testCase}");
            float[] numbers = new float[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter Float {i + 1}: ");
                numbers[i] = float.Parse(Console.ReadLine());
            }

            float max = FindMaximum(numbers);
            Console.WriteLine($"Maximum among the entered numbers: {max}\n");
        }
    }

    static float FindMaximum(float[] values)
    {
        float max = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] > max)
            {
                max = values[i];
            }
        }

        return max;
    }
}