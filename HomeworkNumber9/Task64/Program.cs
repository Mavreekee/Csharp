// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Натуральные числа от {N} до 1: ");
void OutputNumber (int N)
{
    if (N == 0)
    {
        return;
    }
Console.Write($"{N} ");
OutputNumber(N-1);
}
OutputNumber(N);
Console.WriteLine();