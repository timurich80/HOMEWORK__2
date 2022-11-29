/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */



Console.Clear();
System.Console.WriteLine("Введите трехзначное число: ");
string a = Convert.ToString(Console.ReadLine());
if(a.Length > 2)
{
    System.Console.WriteLine($"{a} -> {a[2]}");
}
else Console.WriteLine($" {a} -> третьей цифры нет");