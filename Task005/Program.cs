// Напишите программу, которая будет создавать копию 
/// заданного массива с помощью поэлементного копирования.


int [] CreateArray(int length)     
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)                   
    {
        array[i] = new Random().Next(0,1000);  
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++ ) 
        Console.Write($"{array[i]} ");

    Console.WriteLine();    
           
}

int [] CoppyArray(int[] arr)
{
    int [] newArray = new int [arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}

int [] array = CreateArray(7);
Console.WriteLine();
int[] newArray = CoppyArray(array);
PrintArray(array);
PrintArray(array);
Console.WriteLine();
array[0] = 1;
PrintArray(array);
PrintArray(newArray);