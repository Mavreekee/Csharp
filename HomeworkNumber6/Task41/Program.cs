// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int [] mass = new int [M];
for (int i = 0; i < M; i++)
    {
    Console.Write($"Введите число №{i + 1} = ");
    mass[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Массив введеных чисел: ");
    for (int i = 0; i < M - 1; i++)
    {
    Console.Write($"{mass[i]}, ");
    }
    Console.Write($"{mass[M - 1]}");
countPlus(mass);
void countPlus (int [] mass)
{
    int sum = 0;
    for (int i = 0; i < M; i++)
    {
    if (mass[i] > 0)
    {
        sum = sum + 1;
    }
    }
    Console.Write($"\nКоличество введеных чисел, которые > 0: {sum}");
}