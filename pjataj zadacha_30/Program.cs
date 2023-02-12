// №30 Напишите программу, которая выводит массив из 8ми элементов,
// заполненными нулями и единицами в случайном порядке.

// [0, 0, 1, 0, 1, 1, 1, 0, 0, 1]



Console.Clear();
Console.Write("введите число:");
int num = int.Parse(Console.ReadLine());
Console.Clear();
// int num = 8;
int[] array = GetBinArray(num);
int[] GetBinArray(int mas)
{
  int[] result = new int[mas];
  for (int i = 0; i < mas; i++)
  {
    result[i] = new Random().Next(0, 2);
  }
  return result;
}
Console.WriteLine($"[{String.Join(", ", array)}]");