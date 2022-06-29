// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
Console.Write("Введите длину массива: ");
int maslenght = Convert.ToInt32(Console.ReadLine());
int [] mas = new int [maslenght];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i]  = new Random().Next(100,1000);
    }
searchNumber(mas);
void searchNumber (int [] mas)
{
    int pos = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 == 0)
        {
            pos++;
        }
    }
        Console.Write("Массив: [");
        for (int i = 0; i < mas.Length - 1; i++){
            Console.Write($"{mas[i]}, ");
        }
        Console.Write($"{mas[mas.Length - 1]}");
        Console.Write("]");
        Console.Write($"\nВ данном массиве четных чисел: {pos}");
}