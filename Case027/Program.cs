int A = InputValue("Введите число");
int Sum = 0;
if (IsInputValidat(A))
{
    while (A >= 1)
    {
        Sum = Sum + A % 10;
        A = A / 10;
    }
    Console.WriteLine("Сумма элементов числа = " + Sum);
}
else Console.WriteLine("ошибка");

int InputValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int a = (Math.Abs(int.Parse(value)));
    return a;
}

bool IsInputValidat(int b)
{
    if (b==0)
        return false;
    return true;
}

