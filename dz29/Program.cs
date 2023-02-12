// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



Console.Clear();
Console.Write("введите число:");
int num = int.Parse(Console.ReadLine());
// int num = 8;
int[] array = GetBinArray(num);
int[] GetBinArray(int mas)
{
  int[] result = new int[mas];
  for (int i = 0; i < mas; i++)
  {
    result[i] = new Random().Next(0, 33);
  }
  return result;
}
Console.WriteLine($"[{String.Join(", ", array)}]");