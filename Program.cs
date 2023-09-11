using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть значення a: "); 
        
        //Отримуємо та переводимо значення в тип double
        double a = double.Parse(Console.ReadLine());

        // Обчислення z1
        double z1 = 1 - 1.0 / 4 * Math.Pow(Math.Sin(2 * a), 2) + Math.Cos(2 * a);

        // Обчислення z2
        double z2 = Math.Pow(Math.Cos(a), 2) + Math.Pow(Math.Cos(a), 4);
        
        Console.WriteLine("Значення z1 = " + z1);
        Console.WriteLine("Значення z2 = " + z2);

        Console.ReadLine();
    }
}