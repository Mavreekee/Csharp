// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
int result (int n1, int n2){
    int n3 = 1;
    if (n2 > 0) {
        for (int i = 1; i <= n2; i++){
            n3 *= n1;
        }
    }
    else {
        n3 = 0;
    }
    return n3;
}
Console.Write("Введите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A в степени B = {result(number1, number2)}");