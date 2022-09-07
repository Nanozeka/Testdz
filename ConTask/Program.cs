string[] array = new string[7] { "456", "222", "Russia", "Piter", "num", "34", "Hi" };
string[] array2 = new string[array.Length];
void SelectElemForSecondArray(string[] array, string[] array2)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[temp] = array[i];
            temp++;
        }
    }
}

void PrintArray(string[] array)

{
    Console.WriteLine( "Начальный массив:"  );
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SelectElemForSecondArray(array, array2);
Console.WriteLine();
PrintArray(array);

void PrintArray2(string[] array)

{
    Console.WriteLine( "Полученный массив:"  );
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
PrintArray2(array2);
