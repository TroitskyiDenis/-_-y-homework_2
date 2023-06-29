//Напишите программу,которая принимает на вход трехзначное число и на
// выходе показывает вторую цифру этого чтсла.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int n = int.Parse(Console.ReadLine());
int result  = (n / 100) * 10 + n % 10;
Console.WriteLine($" {n} ->{result} ->{n/10%10}"); 

