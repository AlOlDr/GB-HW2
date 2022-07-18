// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int digit1 = number / 10;
int digit2 = digit1 % 10;
Console.WriteLine($"{digit2} вторая цифра числа");




// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 999){
    number /= 10;

}
if (number > 99 && number <= 999)
{
    Console.WriteLine($"Третья цифра числа {number % 10}");
}
else{
    Console.WriteLine("Третьей цифры нет");
}





// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
// 0 - такого дня недели нет
// 10 - такого дня недели нет

Console.WriteLine("Введите цифру, соответствующую дню недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("нет");
}
else if (number == 2)
{
    Console.WriteLine("нет");
}
else if (number == 3)
{
    Console.WriteLine("нет");
}
else if (number == 4)
{
    Console.WriteLine("нет");
}
else if (number == 5)
{
    Console.WriteLine("нет");
}
else if (number == 6)
{
    Console.WriteLine("да");
}
else if (number == 7)
{
    Console.WriteLine("да");
}
else {
    Console.WriteLine("Такого дня недели нет");
}




// * Напишите программу, которая принимает на вход цифру, обозначающую день недели, а на выходе наименования дня

// 3 -> Среда
// 5 - >Пятница
// 0 или 9 или -1 -> такого дня недели нет

Console.WriteLine("Введите цифру, соответствующую дню недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Понедельник");
}
else if (number == 2)
{
    Console.WriteLine("Вторник");
}
else if (number == 3)
{
    Console.WriteLine("Среда");
}
else if (number == 4)
{
    Console.WriteLine("Четверг");
}
else if (number == 5)
{
    Console.WriteLine("Пятница");
}
else if (number == 6)
{
    Console.WriteLine("Суббота");
}
else if (number == 7)
{
    Console.WriteLine("Воскресенье");
}
else {
    Console.WriteLine("Такого дня недели нет");
}