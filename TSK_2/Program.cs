int digitsSum(int number)
{
    int sum = number % 10;
    int i = 10;
    while (number / i != 0)
    {
        sum = sum + number / i % 10;
        i *= 10;
    }
    return sum;
}

bool check1 = true;
while (check1)
{
    Console.WriteLine("Введите целое число:");
    if (int.TryParse(Console.ReadLine()!, out int number))
    {
        if (number < 0) Console.WriteLine("Число введено неправильно.");
        else
        {
            Console.WriteLine("Сумма цифр в этом числе равна " + digitsSum(number) + ".");
            check1 = false;
        }    
    }
    else Console.WriteLine("Число введено неправильно.");
}