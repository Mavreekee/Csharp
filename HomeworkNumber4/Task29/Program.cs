// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] massiv = new int [8];
void masmetod (int [] masother){
    for (int i = 0; i < masother.Length; i++){
        Console.Write($"Введите элемент №{i+1}: ");
        masother[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Массив - [");
    for (int i = 0; i < masother.Length - 1; i++){
        Console.Write($"{masother[i]}, ");
    }
    Console.Write($"{masother[masother.Length - 1]}");
    Console.Write("]");
}
masmetod(massiv);