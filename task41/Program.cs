/*Console.WriteLine("Введите числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count= count +1;
    }
}
 
Console.WriteLine($"Количество чисел больше нуля равно: {count}");*/
Console.WriteLine("Введите 6 чисел : ");

int size = 6;
int[] array = new int[size];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
   array[i] = Convert.ToInt32( Console.ReadLine()); 
   if (array[i] > 0) count++;
}
Console.Write($"Вы ввели числа [{String.Join("; ", array)}]");
Console.WriteLine($" количество положительных чисел {count}");
