//24 Напишите программу, которая принимает на вход число A
// и выдаёт сумму чисел от 1 до A
// a = 5
// sum = 1 + 2 + 3 + 4 + 5

Console.Clear();
Console.Write("введите число: ");
int n = int.Parse(Console.ReadLine());
int GetSum(int nichay)
{
  int summ = 0;
  for (int i = 1; i <= nichay; i++)
  {
    summ += i;
  }
  return summ;

}
Console.WriteLine($"сумма чисел от 1 до {n} равна {GetSum(n)}");
