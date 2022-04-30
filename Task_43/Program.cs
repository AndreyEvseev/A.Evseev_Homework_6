// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double y1, y2, x, k1, k2, b1, b2;
Console.WriteLine("Введите значения формулы y = k1 * x + b1;");
Console.Write("Значение k1 = ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Значение b1 = ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите значения формулы y = k2 * x + b2;");
Console.Write("Значение k2 = ");
k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Значение b2 = ");
b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
if(k1 == k2) Console.WriteLine("Заданные прямые параллельны и не пересекаются.");
else
{
    x = (b2 - b1) / (k1 - k2);
    y1 = k1 * x + b1; 
    y2 = k2 * x + b2;
    if(k1 * x + b1 == k2 * x + b2) 
    {
        Console.WriteLine($"Заданные прямые пересекаются в координатах ({x}, {y1}).");
    }
    else
    {
        Console.WriteLine("Проверьте формулу в коде");
    }
}

