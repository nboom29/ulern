using System.Runtime.InteropServices;

namespace project3;

class Program
{
    static void Print(int color)
    {
        Console.BackgroundColor = (ConsoleColor)color;
        Console.WriteLine("Hello, World!");
    }
    static void Main(string[] args)
    {
        var color = 0;
        
        for (int i = 0; i < long.MaxValue; i++)
        {
            int maxValue = Enum.GetValues(typeof(ConsoleColor))
                .Cast<int>()   // Преобразуем значения в int
                .Max();        // Находим максимальное значение
            if (color == maxValue)
            {
                Print(color);
                color = 0;
            }
            else
            {
                Print(color);
                color++;
            }   

        }
       
    }
}