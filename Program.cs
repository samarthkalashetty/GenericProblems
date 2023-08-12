using System;

class GenericMaxFinder<T> where T : IComparable<T>
{
    private T[] variables;

    public GenericMaxFinder(params T[] vars)
    {
        if (vars.Length == 0)
        {
            throw new ArgumentException("At least one variable must be provided");
        }

        variables = vars;
    }

    private T FindMax()
    {
        T max = variables[0];
        foreach (T variable in variables)
        {
            if (variable.CompareTo(max) > 0)
            {
                max = variable;
            }
        }
        return max;
    }

    public T TestMaximum()
    {
        return FindMax();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        GenericMaxFinder<int> intFinder = new GenericMaxFinder<int>(3, 7, 1, 9, 4);
        Console.WriteLine($"Max Integer: {intFinder.TestMaximum()}");

        GenericMaxFinder<double> doubleFinder = new GenericMaxFinder<double>(2.5, 1.8, 3.7, 2.0, 3.0);
        Console.WriteLine($"Max Double: {doubleFinder.TestMaximum()}");

        GenericMaxFinder<string> stringFinder = new GenericMaxFinder<string>("apple", "banana", "cherry", "date");
        Console.WriteLine($"Max String: {stringFinder.TestMaximum()}");
    }
}