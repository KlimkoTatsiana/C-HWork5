// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] newArray = RandomArray(7);
PrintArray(newArray);
Console.WriteLine(FindSumONUPosition(newArray));
// FindSumONUPosition = FindSumOfNumsUncountPosition
int FindSumONUPosition(int[] arr)
{
    int sumONUP = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if( i % 2 != 0)
        {
            sumONUP = sumONUP + arr[i];
        }
    }
    return sumONUP;
}

int[] RandomArray(int length)
{
     int[]arr = new int[length];
     for(int i = 0; i < length; i++)
     {
         arr[i] = new Random().Next(0,100);
     }
     return arr;
}

void PrintArray(int[] arr)
{
    
    foreach(int item in arr)
    {
        Console.Write($"{item}, ");
    } 
    System.Console.WriteLine();
}
