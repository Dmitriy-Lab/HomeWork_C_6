// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите число k1:");
double k1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b1:");
double b1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k2:");
double k2= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b2:");
double b2= Convert.ToInt32(Console.ReadLine());

if (k1 - k2 == 0)
{
    if (b2 - b1 == 0)
    {
        Console.WriteLine("Прямые совпадают"); 
    }
    else
    {
        Console.WriteLine("Прямые параллельны"); 
    }
}
else
{
    double x = (b2 - b1) / (k1 - k2);               // Вывел из системы уравнений y = k1 * x + b1, y = k2 * x + b2;
    double y = k1 * x + b1; 
    Console.WriteLine("Точка пересечения прямых: x = "+x+", y = "+y);
}







   