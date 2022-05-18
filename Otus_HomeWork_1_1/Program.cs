using System.Collections;
using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch(); // счётчик для коллекций
Stopwatch stopwatchDiv = new Stopwatch(); // счётчик для остатка от деления
Stopwatch stopwatchAll = new Stopwatch();   // общий счётчик

var n = 496753; // контрольный элемент списка для проверки
var d = 777; // для деления
var x = 1000000; // элементов в массиве
var array1 = new List<int>();
var array2 = new ArrayList();
var array3 = new LinkedList<int>();


stopwatchAll.Start();
Console.WriteLine("-----------------------  Заполнить коллекции, вывести длительность -----------------------");

Console.WriteLine("List");
stopwatch.Start();
for (int i = 1; i < x; i++)
{
    array1.Add(i);
}
stopwatch.Stop();
Console.WriteLine($"Длительность заполнения коллекции: {stopwatch.ElapsedMilliseconds} мс");
stopwatch.Reset();

Console.WriteLine("ArrayList");
stopwatch.Start();
for (var s = 1; s <= x; s++)
{
    array2.Add(s);
}
stopwatch.Stop();
Console.WriteLine($"Длительность заполнения коллекции: {stopwatch.ElapsedMilliseconds} мс");
stopwatch.Reset();

Console.WriteLine("LinkedList");
stopwatch.Start();
for (var l = 1; l <= x; l++)
{
    array3.AddLast(l);
}
stopwatch.Stop();
Console.WriteLine($"Длительность заполнения коллекции: {stopwatch.ElapsedMilliseconds} мс");
stopwatch.Reset();

Console.WriteLine("-----------------------  Найти элемент {0}, вывести длительность  -----------------------", n);
Console.WriteLine("List");
stopwatch.Start();
foreach (var i in array1)
{
    if (i == n)
        Console.WriteLine($"Затрачено для поиска элемента {n}: {stopwatch.ElapsedMilliseconds} мс");
}
stopwatch.Stop();
stopwatch.Reset();

Console.WriteLine("ArrayList");
stopwatch.Start();
foreach (int i in array2)
{
    if (i == n)
        Console.WriteLine($"Затрачено для поиска элемента {n}: {stopwatch.ElapsedMilliseconds} мс");
}
stopwatch.Stop();
stopwatch.Reset();

Console.WriteLine("LinkedList");
stopwatch.Start();
foreach (int i in array3)
{
    if (i == n)
        Console.WriteLine($"Затрачено для поиска элемента {n}: {stopwatch.ElapsedMilliseconds} мс");
}
stopwatch.Stop();
stopwatch.Reset();

Console.WriteLine("-----------------------  Найти элемент, который делится без остатка на {0}, вывести длительность  -----------------------", d);
Console.WriteLine("List");
stopwatch.Start();
foreach (var i in array1)
{
    if (i % d == 0)
    {
        Console.WriteLine($"{i} без остатка делится на {d}");
    }
}
stopwatch.Stop();
Console.WriteLine($"Затрачено милисекунд для поиска операции деления без остатка: {stopwatch.ElapsedMilliseconds}");
stopwatch.Reset();

Console.WriteLine("ArrayList");
stopwatch.Start();
foreach (int i in array2)
{
    if (i % d == 0)
    {
        Console.WriteLine($"{i} без остатка делится на {d}");
    }
}
stopwatch.Stop();
Console.WriteLine($"Затрачено милисекунд для поиска операции деления без остатка: {stopwatch.ElapsedMilliseconds}");
stopwatch.Reset();

Console.WriteLine("LinkedList");
stopwatch.Start();
foreach (int i in array3)
{
    if (i % d == 0)
    {
        Console.WriteLine($"{i} без остатка делится на {d}");
    }
}
stopwatch.Stop();
Console.WriteLine($"Затрачено милисекунд для поиска операции деления без остатка: {stopwatch.ElapsedMilliseconds}");
stopwatch.Reset();

stopwatchAll.Stop();
Console.WriteLine($"Затрачено милисекунд для работы программы: {stopwatchAll.ElapsedMilliseconds}");