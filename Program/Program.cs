
//string [] array = {"One", "2", "Three", "Four"};

string [] CreateStringArray()
{
    Console.Write("Введите размер массива: ");
    int n = int.Parse(Console.ReadLine()!);
    string [] arr = new string[n]; 
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите элемент массива с индексом {i}: ");
        arr[i] = Console.ReadLine()!;
    }
    return arr;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
string[] SelectionArrayToArray2(string[] array)
{
    string [] array2 = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            array2[count] = array[i]; 
            count++; 
        }
    }
    return array2;
}

string [] array = CreateStringArray();
Console.WriteLine("Исходный массив: ");
PrintArray(array);
string[] array2 = SelectionArrayToArray2(array);
Console.WriteLine("Результат отбора элементов длина которых меньше, либо равна 3 символам: ");
PrintArray(array2);