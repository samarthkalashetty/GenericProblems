using System;

class GenericMaxFinder<T> where T : IComparable<T>
{
    private T variable1;
    private T variable2;
    private T variable3;

    public GenericMaxFinder(T var1, T var2, T var3)
    {
        variable1 = var1;
        variable2 = var2;
        variable3 = var3;
    }

    private T FindMax(T a, T b, T c)
    {
        T max = a;
        if (b.CompareTo(max) > 0)
        {
            max = b;
        }
        if (c.CompareTo(max) > 0)
        {
            max = c;
        }
        return max;
    }

    public T TestMaximum()
    {
        return FindMax(variable1, variable2, variable3);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        GenericMaxFinder<int> intFinder = new GenericMaxFinder<int>(3, 7, 1);
        Console.WriteLine($"Max Integer: {intFinder.TestMaximum()}");

        GenericMaxFinder<double> doubleFinder = new GenericMaxFinder<double>(2.5, 1.8, 3.7);
        Console.WriteLine($"Max Double: {doubleFinder.TestMaximum()}");

        GenericMaxFinder<string> stringFinder = new GenericMaxFinder<string>("apple", "banana", "cherry");
        Console.WriteLine($"Max String: {stringFinder.TestMaximum()}");
    }
}