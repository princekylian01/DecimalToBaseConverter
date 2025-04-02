using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        string input = Console.ReadLine().ToUpper();

        Console.Write("Введите основание исходной системы (2–20): ");
        int fromBase = int.Parse(Console.ReadLine());

        Console.Write("Введите основание целевой системы (2–20): ");
        int toBase = int.Parse(Console.ReadLine());

        int decimalValue = ConvertToDecimal(input, fromBase);
        string result = ConvertFromDecimal(decimalValue, toBase);

        Console.WriteLine($"Результат: {result}");
    }

    static int ConvertToDecimal(string number, int fromBase)
    {
        int result = 0;

        foreach (char c in number)
        {
            int digit;

            if (Char.IsDigit(c))
                digit = c - '0';
            else
                digit = c - 'A' + 10;

            result = result * fromBase + digit;
        }

        return result;
    }

    static string ConvertFromDecimal(int number, int toBase)
    {
        if (number == 0) return "0";

        string result = "";

        while (number > 0)
        {
            int remainder = number % toBase;
            string symbol = remainder < 10
                ? remainder.ToString()
                : ((char)('A' + remainder - 10)).ToString();

            result = symbol + result;
            number /= toBase;
        }

        return result;
    }
}
