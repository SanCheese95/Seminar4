// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Pow(int num1, int num2)
{
    int result = num1;
    for(int i = 1; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}

int GetInfo (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num1 = GetInfo("Введите число A: ");
int num2 = GetInfo("Введите число B: ");

Console.WriteLine($"Число {num1} в степени {num2} равно {Pow(num1, num2)}");