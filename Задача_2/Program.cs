//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 999)
{
n /= 10;
}
   {
    Console.WriteLine(n % 10);
   }
if (n < 100)
{
Console.WriteLine("Такой цифры нет");
}




