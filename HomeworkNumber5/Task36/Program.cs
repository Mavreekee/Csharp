// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях
Console.Write("Введите длину массива: ");
int maslenght = Convert.ToInt32(Console.ReadLine());
int [] mas = new int [maslenght];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i]  = new Random().Next(-100,101);
    }
searchNumber(mas);
void searchNumber (int [] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if ((i % 2) != 0)
        {
            sum = sum + mas[i];
        }
    }
        Console.Write("Исходный массив: [");
        for (int i = 0; i < mas.Length - 1; i++){
            Console.Write($"{mas[i]}, ");
        }
        Console.Write($"{mas[mas.Length - 1]}");
        Console.Write("]");
        Console.Write($"\nСумма элементов массива, находящихся на нечетных позициях = {sum}");
}