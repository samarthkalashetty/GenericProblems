using System;
using System.Collections.Generic;

class Refactor1
{
    public static T FindMax<T>(IEnumerable<T> collection) where T : IComparable<T>
    {
        if (collection == null)
        {
            throw new ArgumentNullException(nameof(collection), "Collection must not be null");
        }

        T max = default(T);
        bool isFirstElement = true;

        foreach (T element in collection)
        {
            if (isFirstElement || element.CompareTo(max) > 0)
            {
                max = element;
                isFirstElement = false;
            }
        }

        if (isFirstElement)
        {
            throw new ArgumentException("Collection must not be empty");
        }

        return max;
    }

    static void Main(string[] args)
    {
        // Example usage
        List<int> integers = new List<int> { 3, 7, 1, 9, 4 };
        int maxInt = FindMax(integers);
        Console.WriteLine($"Max Integer: {maxInt}");

        List<double> doubles = new List<double> { 2.5, 1.8, 3.7, 2.0, 3.0 };
        double maxDouble = FindMax(doubles);
        Console.WriteLine($"Max Double: {maxDouble}");

        List<string> strings = new List<string> { "apple", "banana", "cherry", "date" };
        string maxString = FindMax(strings);
        Console.WriteLine($"Max String: {maxString}");
    }
}