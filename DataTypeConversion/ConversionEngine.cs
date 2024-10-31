namespace DataTypeConversion;

public class ConversionEngine
{
    public static int SumCharacters(string username)
    {
        int sum = 0;

        foreach (char c in username.ToCharArray())
        {
            sum += c;
        }

        return sum;
    }


    public static void PrintAlphabet(char alphabetType)
    {
        if (alphabetType == 'a')
        {
            for (char c = alphabetType; c <= 'z'; c++)
            {
                Console.Write($"{c} ");
            }
            return;
        }

        if (alphabetType == 'A')
        {
            for (char c = alphabetType; c <= 'Z'; c++)
            {
                Console.Write($"{c} ");

                if (c == 'T')
                {
                    break;
                }
            }
            return;
        }

        Console.WriteLine("Invalid input. Please enter 'a' for lowercase or 'A' for uppercase.");
    }

    public static void PrintAlphabet2(char alphabetType)
    {
        switch (alphabetType)
        {
            case 'a':
                for (char c = alphabetType; c <= 'z'; c++)
                {
                    if (c == 't')
                    {
                        c++;
                        continue;
                    }

                    Console.Write($"{c} ");
                }
                break;
            case 'A':
                for (char c = 'A'; c <= 'Z'; c++)
                {
                    Console.Write($"{c} ");
                }
                break;
            default:
                Console.WriteLine("Invalid input. Please enter 'a' for lowercase or 'A' for uppercase.");
                break;
        }
    }
}