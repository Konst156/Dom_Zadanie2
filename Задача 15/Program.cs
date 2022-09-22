// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());

if (a >= 1 & a <= 5  ) {
    Console.WriteLine("Нет");
} if (a == 6 ^ a == 7)
{
    Console.WriteLine("Да");
}