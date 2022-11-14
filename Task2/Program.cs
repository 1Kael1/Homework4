// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");

int a = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num1)
{
    int number = 0;
    // int num2 = num1;
    while (num1 > 0)
    {
        number += num1 % 10 ;
        Console.WriteLine($"{num1}");
        num1 /= 10;

    }

    return number;
}
int sum = SumDigits(a);
Console.WriteLine($"Сумма цифр в числе {a} равно --> {sum}");