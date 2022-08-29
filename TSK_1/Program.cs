int CheckNumbers(string param)
{
    while (true)
    {
        Console.Write($"Введите целое число {param}: ");
        if (int.TryParse(Console.ReadLine()!, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Число введено неправильно.");
        }
    }
}

long powerAtoB(int A,int B)
{
    long result = 1;
    for (int i = 1; i <= B; i++) result *= A;
    return result;
}

Console.WriteLine("А в степени В равно " + powerAtoB(CheckNumbers("A"),CheckNumbers("B")) + ".");
