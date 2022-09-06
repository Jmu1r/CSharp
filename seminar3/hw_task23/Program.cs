// 23. Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
int c = 1;

if (n > 0)
{
    while (c <= n)
    {
        double I = Math.Pow(i, 3);
        Console.Write(I + " ");
        c = c + 1;
        i = c;        
    }
}
else
{
    Console.WriteLine("Число отрицательное или ноль!");
}