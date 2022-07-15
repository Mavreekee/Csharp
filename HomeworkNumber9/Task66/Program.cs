// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма натуральных чисел в промежутке от {M} до {N} = ");
int sumNumber (int M, int N)
{
    if (M == N)
    {
        return M;
    }
    return M + sumNumber(M + 1, N);
}
Console.Write(sumNumber(M,N));