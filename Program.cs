using System;

class MaxNumberFinder<T> where T : IComparable<T>
{
    public static T FindMaxNumber(T num1, T num2, T num3)
    {
        T max = num1;

        if (num2.CompareTo(max) > 0)
        {
            max = num2;
        }

        if (num3.CompareTo(max) > 0)
        {
            max = num3;
        }

        return max;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

        int maxNumber = MaxNumberFinder<int>.FindMaxNumber(num1, num2, num3);
        Console.WriteLine("Maximum number: " + maxNumber);
    }
}
