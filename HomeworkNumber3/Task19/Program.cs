// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Write("Введите пятизначное число: ");
int palindromint = Convert.ToInt32(Console.ReadLine());
if (palindromint > 9999 && palindromint < 100000)
{
    string palindromstring = palindromint.ToString();
    if (palindromstring[0] == palindromstring[4] && palindromstring[1] == palindromstring[3])
    {
    Console.WriteLine($"{palindromint} - это число является палиндромом");
    }
    else
    {
     Console.WriteLine($"{palindromint} - это число не является палиндромом");
    }
}
else
{
     Console.WriteLine($"{palindromint} - это не пятизначное число");
}