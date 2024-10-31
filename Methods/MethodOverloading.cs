namespace Methods;

public class MethodOverloading
{
    /**
        -  Different types of parameters
        -  Numbers of parameters
        -  Order of parameters 
    */
    public static int AddNumbers(int firstNumberArg, int secondNumberArg)
    {
        return firstNumberArg + secondNumberArg;
    }

    public static double AddNumbers(double firstNumberArg, double secondNumberArg)
    {
        return firstNumberArg + secondNumberArg;
    }

    public static decimal AddNumbers(decimal firstNumberArg, decimal secondNumberArg)
    {
        return firstNumberArg + secondNumberArg;
    }

    public static void Print()
    {
        Console.WriteLine();
    }

    public static void Print(string message)
    {
        Console.WriteLine(message);
    }

    public static void Print(string message, int number)
    {
        Console.WriteLine($"{message} {number}");
    }

    public static void Print(int number, string message)
    {
        if (number == 0)
        {
            number = int.MaxValue;
        }

        Console.WriteLine($"{number} {message}");
    }
}
