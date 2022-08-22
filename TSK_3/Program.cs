void Array()
{
    Random rndm = new Random();
    int [] array = new int[8];
    Console.Write("[");
    for (int i = 0;i < array.Length;i++)
    {
        array[i] = rndm.Next(1,101);
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }    
}

Console.WriteLine("Массив из 8 случайных чисел от 1 до 100:");
Array();