int min = InputValue("Введите минимальное значение");
int max = InputValue("Введите максимальное значение");
Console.WriteLine("Введите количество элементов массива");
int N = int.Parse(Console.ReadLine());
if (IsInputValidat(min, max))
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    PrintArray(array);
}
else Console.WriteLine("ошибка данных");

int InputValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int a = int.Parse(value);
    return a;
}

bool IsInputValidat(int a, int b)
{
    if (a > b)
        return false;
    return true;
}

void PrintArray(int[] collection)
{
    Console.Write("[");
    for (int i = 0; i < collection.Length-1; i++)
    {
        Console.Write(collection[i] + ",");
    }
    Console.Write(collection.Length + "]");
}




//второй вариант с Trim, исправлено:)

// int min = InputValue("Введите минимальное значение");
// int max = InputValue("Введите максимальное значение");
// Console.WriteLine("Введите количество элементов массива");
// int N = int.Parse(Console.ReadLine());
// if (IsInputValidat(min, max))
// {
//     int[] array = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     Console.WriteLine(PrintArray(array));
// }
// else Console.WriteLine("ошибка данных");

// int InputValue(string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine();
//     int a = int.Parse(value);
//     return a;
// }

// bool IsInputValidat(int a, int b)
// {
//     if (a > b)
//         return false;
//     return true;
// }

// string PrintArray(int[] array)
// {
//     string msg = "[";
//     foreach (int i in array)
//     {
//         msg +=i + ",";
//     }
//     msg = msg.TrimEnd(',');
//     msg += "]";
//     return msg;
// }
