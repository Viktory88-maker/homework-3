// Задача 23. Напишите программу, которая принимает на вход
// число(N) и выдает таблицу кубов чисел от 1 до N
// 3 -> 1,8,27
Console.WriteLine ("Введите число N");
int n = int.Parse(Console.ReadLine()!);
for(int i = 1; i < n; i++) Console.Write(Math.Pow(1, 3) + ", ");
Console.Write(Math.Pow(n, 3));
