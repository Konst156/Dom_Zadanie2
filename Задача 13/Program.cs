// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Math.Abs(int.Parse(Console.ReadLine()));

if (num < 100){
    Console.WriteLine("Третьей цифры нет");
    return;
} 
if (num > 100 & num < 1000){
    Console.WriteLine($"Третья цифра - {num % 10}");
}
else {
    while (num > 999){
        num = num /10;
    }
    Console.WriteLine($"Третья цифра - {num % 10}");
}
