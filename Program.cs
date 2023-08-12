using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the test data: ");
        int size = int.Parse(Console.ReadLine());

        Console.Write("Enter the minimum value: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Enter the maximum value: ");
        int max = int.Parse(Console.ReadLine());

        int[] testData = GenerateTestData(size, min, max);
        PrintArray("Original Test Data:", testData);

        // Finding and moving the maximum number to the first position
        MoveMaxToFirstPosition(testData);

        PrintArray("Test Data with Max Number at 1st Position:", testData);
    }

    static int[] GenerateTestData(int size, int min, int max)
    {
        Random random = new Random();
        int[] testData = new int[size];

        for (int i = 0; i < size; i++)
        {
            testData[i] = random.Next(min, max + 1);
        }

        return testData;
    }

    static void MoveMaxToFirstPosition(int[] data)
    {
        int maxIndex = 0;
        int maxValue = data[0];

        for (int i = 1; i < data.Length; i++)
        {
            if (data[i] > maxValue)
            {
                maxIndex = i;
                maxValue = data[i];
            }
        }

        if (maxIndex != 0)
        {
            int temp = data[0];
            data[0] = data[maxIndex];
            data[maxIndex] = temp;
        }
    }

    static void PrintArray(string label, int[] array)
    {
        Console.WriteLine(label);
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}