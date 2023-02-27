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

string[] FillResultArray(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
            Console.Write($"{array[i]}, ");
        else 
            Console.Write($"{array[i]}]");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите массив элементов через пробел:");
string[] array = Console.ReadLine()!.Split(' ');
int count = CountString(array);
string[] result =  FillResultArray(array,count);
PrintArray(result);