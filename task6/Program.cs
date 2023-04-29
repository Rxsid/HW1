// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int mod = numberA % 2;
if (mod == 0)
{
Console.Write($"Число {numberA} - четное");
}
else
{
Console.WriteLine($"Число{numberA} - нечетное");
}