// Напишите программу, 
// которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3  -> 11
// 2  -> 10


int GetLentMirray(int number)     
{
    int len = 0;
    while (number >= 1)                  
    {
        number = number / 2;
        len++;  
    }
    return len;
}

int[] Translation(int number)
{
    int[] array = new int[GetLentMirray(number)];
    for(int i = 0; i < array.Length; i++)
    {
        array[array.Length - 1 - i] = number % 2;
        number = number / 2;
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++ ) 
        Console.Write($"{array[i]} ");    
    Console.WriteLine();       
}

int [] myArray = Translation(45);
PrintArray(myArray);
//Console.WriteLine(GetLentMirray(8));

