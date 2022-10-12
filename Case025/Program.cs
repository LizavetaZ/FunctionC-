double a = InputValue1("Введите число A");
int b = InputValue2("Введите число B");
int i = 1;
double Exponentiation = 1;
bool IsValidat = IsInputValidat(b);
if (IsValidat)
{
    while(i<=b)
    {
        Exponentiation = Exponentiation*a;
        i++;
    }
    Console.WriteLine($"Возведение в степень = " + Exponentiation);
}
else if (b == 0) 
{
    Console.WriteLine($"Возведение в степень = " + Exponentiation);
}
else Console.WriteLine("Неверные данные");

double InputValue1(string message)
{
    Console.WriteLine(message);
    double value1 = double.Parse(Console.ReadLine());
    return value1;
}

int InputValue2(string message)
{
    Console.WriteLine(message);
    int value2 = int.Parse(Console.ReadLine());
    return value2;
}

bool IsInputValidat(int b)
{
    if (b<0)
        return false;
    return true;
}
