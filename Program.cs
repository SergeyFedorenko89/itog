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