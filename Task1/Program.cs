// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

int MultNumbers(int num1, int num2)
{
    int number = num1;
        for (int count = 1; count < num2; count++)
        {
            number *= num1;
        }
    return number;
}
if(b > 0 )
{
int multiply = MultNumbers(a, b);
Console.WriteLine($"Число {a} в степени {b} равно --> {multiply}");
}

else Console.WriteLine("Введена неверная степень числа");