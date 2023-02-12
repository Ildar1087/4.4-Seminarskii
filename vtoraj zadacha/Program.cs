
// 26 Напишите программу,
//  которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("введите число: ");
int num = int.Parse(Console.ReadLine());
int num1 = num;
int revers = 0; //54321
while (num > 0) // num 0>0  
{
  revers = revers * 10 + num % 10; // = 54321*10 + num%10(12345%10) =54321
  num/=10; // num / 10(1/10)
}// 12345 == 54321
if (num1 == revers)
{
  Console.WriteLine("Да");
}
else
{
  Console.WriteLine("Нет");
}
