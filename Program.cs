﻿// Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int userNum = int.Parse(Console.ReadLine() ?? "");
string[] array = FillArray(userNum);

string[] FillArray(int n)
{
    string[] fillArray = new string[n];
    Console.WriteLine($"Введите элемент массива:");
    for (int i = 0; i < n; i++) fillArray[i] = Console.ReadLine() ?? "";    
    return fillArray;
}
