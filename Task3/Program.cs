double[] CreateAndFillArray(int Number)
{
    double[] array = new double[Number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((new Random().NextDouble()), 3);
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");

    }
    System.Console.WriteLine();
    System.Console.WriteLine();
}

void DifferenceMinMaxNumbers(double[] array)
{
    double min = array[0];
    double max = array[1];
    double result;
    for (int i = 0; i < array.Length; i++)
    {
        if (max <= array[i])
        {
            max = array[i];
        }
        
        if (min >= array[i])
        {
            min = array[i];
        }
    }
        result = max - min;
    Console.WriteLine($"{max} - {min} = {result}");
    }

double[] array = CreateAndFillArray(5);
ShowArray(array);
DifferenceMinMaxNumbers(array);