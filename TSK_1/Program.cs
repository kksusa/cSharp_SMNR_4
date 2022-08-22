long powerAtoB(int A,int B)
{
    long result = 1;
    for (int i = 1; i <= B; i++) result *= A;
    return result;
}
bool check1 = true;
bool check2 = true;

while (check1)
{
    Console.WriteLine("Введите целое число А:");
    if (int.TryParse(Console.ReadLine()!, out int number1))
    {
        check1 = false;
        while (check2)
        {
        Console.WriteLine("Введите целое число В:");
        if (int.TryParse(Console.ReadLine()!, out int number2))
        {
            if (number2 < 0) Console.WriteLine("Число В введено неправильно.");
            else
            {
                check2 = false;
                Console.WriteLine("А в степени В равно " + powerAtoB(number1,number2) + ".");
            } 
        }
        else Console.WriteLine("Число В введено неправильно.");
        }
    }
    else Console.WriteLine("Число А введено неправильно.");
}