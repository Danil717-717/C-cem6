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
    // for(int i = array.Length; i >= 0; i--)
    for(int i = 0; i < array.Length; i++)
    {
        //array[i] = number % 2;
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


// через строки

void MakeBinary()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    string binary = string.Empty;
    int n = number;
    while (n > 0)
    {
        binary = $"{n % 2}" + binary;
        n /= 2;
    }

    Console.WriteLine($"{number} -> {binary}");
}

MakeBinary();






