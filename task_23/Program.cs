﻿// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число");

string firstString = Console.ReadLine();
 
int firstArg = Convert.ToInt32(firstString);
void PrintCubesToConsole(int n)
{
    for(int i = 1; i <= n; i ++)
    {
        Console.WriteLine(i*i*i);
        
    }
}

PrintCubesToConsole(firstArg);
