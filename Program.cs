int CountString(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
            count++;
    }
    return count;
}


Console.WriteLine("Введите массив элементов через пробел:");
string[] array = Console.ReadLine()!.Split(' ');
int count = CountString(array);

