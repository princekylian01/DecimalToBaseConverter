string result = "";
int number = 3302;
int system = 16;

while (number > 0)
{
    int remainder = number % system;
    string symbol = remainder < 10
        ? remainder.ToString()
        : ((char)('A' + remainder - 10)).ToString();

    result = symbol + result;
    number = number / system;
}

Console.WriteLine(result);
