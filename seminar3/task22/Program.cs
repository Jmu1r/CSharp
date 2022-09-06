// 22: Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
int c = 1;

if (n > 0)
{
    while (c <= n)
    {
        double I = Math.Pow(i, 2);
        Console.Write(I + " ");
        c = c + 1;
        i = c;        
    }
}
else
{
    Console.WriteLine("Число отрицательное или ноль!");
}