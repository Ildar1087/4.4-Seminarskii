// напишите программу, которая принимает на вход число N, 
// и выдает произведение чисел от 1 до N.

// 4 -> 24 1*2*3*4 = 24
// 5 -> 120 1*2*3*4*5 = 120

Console.Clear();
Console.Write("Введите ваше число: ");
int n = int.Parse(Console.ReadLine());
int Kvadrat(int chis)
{
  int s = 1;
  for (int i = 1; i <= n; i++)
  {
    s *= i;
  }
  return s;
}
Console.WriteLine($"{Kvadrat(n)}");