// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumAllDigit( int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

int GetInfo (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число: ");

Console.WriteLine($"Сумма цифр в числе {num} равна {SumAllDigit(num)}");