// Доп. задание. Написать метод для разворота массива, 
// не используя память под дополнительный массив

int[] array = new int[5];
Random rand = new Random();
for (int n = 0; n < array.Length; n++)
   array[n] = rand.Next(1, 100);

int L = array.Length;

Console.WriteLine($"Длина массива - {L}");
Console.Write("Первоначальный массив: ");

foreach (int ar in array)
{
Console.Write(ar + " ");
}

Console.Write("Новый массив: ");

int i = 0;
int j = 0;
int a = L;

while (j < L - 1)
{
    while (i < a - 1)
    {
        int t = array[i];
        array[i] = array[i + 1];
        array[i + 1] = t;
        i = i + 1;
    }
j = j + 1;
a = a - 1;
i = 0;
}
foreach (int arr in array)
{
Console.Write(arr + " ");
}