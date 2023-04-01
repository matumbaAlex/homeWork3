// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
Console.Write("Enter number :");
int numA = int.Parse(Console.ReadLine()!);
if (numA < 10000 || numA > 99999)Console.Write("число не является пятизначным");
else 
{
    if(numA / 10000 == numA % 10 && numA / 1000 % 10 == numA / 10 % 10)
    {
        Console.Write("является  палиндромом");
    }
    else Console.Write(" не является  палиндромом");
}


