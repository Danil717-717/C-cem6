// Напишите программу, которая принимает на вход три числа 
// и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше 
// суммы двух других сторон

int a = 2;
int b = 4;
int c = 15;

if(a < b + c && b < a + c && c < a + b)
    Console.WriteLine("Существ");
else  Console.WriteLine("не Существ");   




void Rect(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b)
    Console.WriteLine("Существ");
    else  Console.WriteLine("не Существ");  
}
Rect(2, 4, 15);



bool CheckTraing(int a, int b, int c)
{
    // return (a < b + c && b < a + c && c < a + b)
    if(a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

void IsTraing()
{
    int[] triangle = new int[3];
    for(int i = 0; i < 3; i++)
    {
        Console.Write($"Введите длинну {i+1}-й стороны: ");
        triangle[i] = Convert.ToInt32(Console.ReadLine());
    }

    if(CheckTraing(triangle[0],triangle[1],triangle[2]))
    {
        Console.WriteLine($"Треугольник со сторонами {triangle[0]}, {triangle[1]}, {triangle[2]} существует ");
    }
    else Console.WriteLine($"Треугольник со сторонами {triangle[0]}, {triangle[1]}, {triangle[2]} не существует ");
}

CheckTraing(2, 4, 15);
IsTraing();




