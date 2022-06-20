// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Write("Введите № дня недели: ");
int numberDAY = int.Parse(Console.ReadLine());
if (numberDAY == 1)
{
    Console.WriteLine($"№{numberDAY} - это не выходный день, а рабочий");
}
else if (numberDAY == 2)
{
    Console.WriteLine($"№{numberDAY} - это не выходный день, а рабочий");
}
else if (numberDAY == 3)
{
    Console.WriteLine($"№{numberDAY} - это не выходный день, а рабочий");
}
else if (numberDAY == 4)
{
    Console.WriteLine($"№{numberDAY} - это не выходный день, а рабочий");
}
else if (numberDAY == 5)
{
    Console.WriteLine($"№{numberDAY} - это не выходный день, а рабочий");
}
else if (numberDAY == 6)
{
    Console.WriteLine($"№{numberDAY} - это выходный день, поздравляю!");
}
else if (numberDAY == 7)
{
    Console.WriteLine($"№{numberDAY} - это выходный день, поздравляю!");
}
else 
{
    Console.WriteLine($"Дня недели под №{numberDAY} нет");
}