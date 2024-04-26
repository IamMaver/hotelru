String GetDeclination(int number) //Задача 1
{
    String result = number.ToString() + " компьютер";
    if (number % 100 > 4 && number % 100 < 21)
    {
        result += "ов";
    }
    else
    {
        if (number % 10 != 1)
        {
            if (number % 10 >= 2 && number % 10 <= 4)
            {
                result += "а";
            }
            else
            {
                result += "ов";
            }
        }
    }

    return result;
}

bool IsRrime(long n)
{
    for (long i = 2; i <= Math.Sqrt(n); i++)
        if (n % i == 0)
            return false;
    return true;
}


Array GetCommonDivisors(int[] numbers) // Задача 2
{
    List<int> commonDivisors = new List<int>();
    int minNumber = numbers[0];
    foreach (int num in numbers)
    {
        if (num < minNumber)
        {
            minNumber = num;
        }
    }

    for (int i = 2; i <= minNumber; i++)
    {
        bool isCommonDivisor = true;
        foreach (int num in numbers)
        {
            if (num % i != 0)
            {
                isCommonDivisor = false;
                break;
            }
        }

        if (isCommonDivisor)
        {
            commonDivisors.Add(i);
        }
    }

    return commonDivisors.ToArray();
}


Array GetPrimeArray(int min, int max) //Задача 3 
{
    List<int> result = new();
    for (int i = min; i <= max; i++)
    {
        if (IsRrime(i))
        {
            result.Add(i);
        }
    }

    return result.ToArray();
}

void DrawMulTable(int number) // Задача 4 
{
    int maxLength = (number * number).ToString().Length; // Для красивого форматирования
    for (int i = 0; i <= number; i++)
    {
        for (int j = 1; j <= number; j++)
        {
            if (j == 1)
            {
                if (i == 0)
                {
                    Console.Write("".PadLeft(maxLength + 1));
                }
                else
                {
                    Console.Write(j.ToString().PadLeft(maxLength + 1));
                }
            }

            if (i > 0)
            {
                Console.Write((i * j).ToString().PadLeft(maxLength + 1));
            }
            else
            {
                Console.Write(j.ToString().PadLeft(maxLength + 1));
            }
        }

        Console.WriteLine();
    }
}