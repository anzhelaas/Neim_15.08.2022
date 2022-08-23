//  Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите целое число ");
int num1 = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите целое число ");
int num2 = Convert.ToInt32(Console.ReadLine ());

int num3 = 1;
for (int i = 1; i <= num2; i++)
{
    num3 = num3 * num1;
}
Console.WriteLine($"если {num1} возвести в степень {num2}, то получим {num3}");
