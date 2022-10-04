Console.WriteLine("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int enk = 4;
string[] CreateArray()
{
    string[] enkArray = new string[size];
    for(int i = 0; i < size; i = i + 1)
    {
        Console.Write($"Введите элемент {i + 1}: ");
        enkArray[i] = Console.ReadLine();
    }
    return enkArray;
}
void ShowArray(string[] array)
{
    for(int i = 0; i < size; i++) Console.Write($" {array[i]} ");
}
string[] SecArray(string[] array)
{
    string[] newArray = new string[array.Length];
    for(int i = 0; i < size; i++)
    {
        if(array[i].Length < enk)
        {
            newArray[i] = array[i];
        }
    }
    return newArray;
}
string[] TopArray = CreateArray();
Console.WriteLine($"Первый массив: ");
ShowArray(TopArray);
Console.WriteLine();
Console.WriteLine($"Второй массив: ");
ShowArray(SecArray(TopArray));