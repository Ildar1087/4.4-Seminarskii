// напишите программу, которая принимает на вход число, а в конце пишет 
// из скольких символов, оно состоит.
// например:
// 12345 -> 5
// 234 -> 3


Console.Clear();
Console.Write("введите число: ");
int x = int.Parse(Console.ReadLine());
// int z = 0;
int CountNumber(int n)
{
  int z = 0;
  int count = 0;

  if (n < 0)
  {
    n *= (-1);
  }
  while (n > 0)
  {
    count++;
    z = (n) / 10;
  }
  return z;
}
Console.WriteLine($" {CountNumber(x)}");
