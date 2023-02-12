// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.Clear();
Console.Write("введите число: ");
int n = int.Parse(Console.ReadLine());
Console.Write("введите степень: ");
int z = int.Parse(Console.ReadLine());
int Kvadrat(int chi)
{
  int sum = n;
  for (int i = 1; i < z; i++)
  {
    sum = sum*n;
  }
  return sum;
}
Console.WriteLine($"{Kvadrat(n)}");