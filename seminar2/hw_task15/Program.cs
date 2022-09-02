// 15. Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите числом день недели, для проверки выходной ли день: ");
int number = Convert.ToInt32(Console.ReadLine());{

if (number == 1)
{
    Console.WriteLine("Нет");
}
if (number == 2)
{
    Console.WriteLine("Нет");
}
if (number == 3)
{
    Console.WriteLine("Нет");
}
if (number == 4)
{
    Console.WriteLine("Нет");
}
if (number == 5)
{
    Console.WriteLine("Нет");
}
if (number == 6)
{
    Console.WriteLine("Да");
}
if (number == 7)
{
    Console.WriteLine("Да");
}

if (number < 1 || number > 7) 
{
    Console.WriteLine("В неделе всего 7 дней!!!))");
}
}