// Напишите программу, которая принимает на вход
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int res = 0;

for (sum = 0; number > 0; sum += res)
{
    res = number % 10;
    number = number / 10;
}

Console.WriteLine($"Сумма цифр в числе составит {sum} ");
