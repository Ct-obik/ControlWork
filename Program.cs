// Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int userNum = int.Parse(Console.ReadLine() ?? "");
string[] array = FillArray(userNum);
string[] newArray = FindElementsInArray(array);
Console.Write($"{String.Join(", ", newArray)}");

string[] FillArray(int n)
{
    string[] fillArray = new string[n];
    Console.WriteLine($"Введите элемент массива:");
    for (int i = 0; i < n; i++) fillArray[i] = Console.ReadLine() ?? "";    
    return fillArray;
}

string [] FindElementsInArray(string [] array)
{
    string [] temp = new string [array.Length];

    int number = 0;
    for(int i=0; i<array.Length; i++)
    {
            if(array[i].Length<=3)
        {
            temp[number] = array[i];
            number++;
        } 
    }

    string [] newArray = new string [number];

    for(int i =0; i<number; i++)
    {
    newArray[i] = temp[i];
    }
    return newArray;
}
