int[] CreateAndFillArray(int Number)
{
    int [] array = new int [Number];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,6);
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
    System.Console.WriteLine();
}
void SumOddNumbers(int[] array)
{
    int SumOdd  = 0;
    for(int i =0; i<array.Length;i++)
    {
        if(array[i] % 2 != 0)
        {
            SumOdd = SumOdd +array[i];
        }
    }
    System.Console.WriteLine(SumOdd);
}
int[] arr = CreateAndFillArray(5);
ShowArray(arr);
SumOddNumbers(arr);