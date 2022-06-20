int[] CreateAndFillArray(int Number)
{
    int [] array = new int [Number];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}
void ShowArray(int [] array)
{
    for(int i =0; i<array.Length;i++)
    {
        Console.Write($"{array[i]}  ");
        
    }
    System.Console.WriteLine();
}

void CountOfEvenNumbers(int[] array)
{
    int count = 0;
    for(int i =0; i<array.Length;i++)
    {
        if(array[i]%2 == 0)
        {
            count++;
        }
    }
    System.Console.WriteLine($"Кол-во четных чисел {count}");
}

int[] arr = CreateAndFillArray(10);
ShowArray(arr);
CountOfEvenNumbers(arr);