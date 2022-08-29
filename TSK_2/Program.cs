int digitsSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
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