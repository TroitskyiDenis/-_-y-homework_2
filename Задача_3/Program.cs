//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Clear();
Console.WriteLine("Введите номер дня недели");
int n = int.Parse(Console.ReadLine());
if(n>5 && n<=7)
{
    Console.WriteLine("Выходной");
}
else
{
  Console.WriteLine("Рабочий день");
}
if(n > 8)
{
 Console.WriteLine("Это не день недели");   
}