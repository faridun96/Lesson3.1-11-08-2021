using System;

namespace _4NumberApp
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.Write("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число:");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Введите четвертое число:");
            int d = int.Parse(Console.ReadLine());
            int result;
            if (a<b && b<c && c<d)
            {
                Console.WriteLine($"Числа расположены по возрастанию");
            }
            else if (a==b && b==c && c==d)
            {
                Console.WriteLine($"Числа равны");
                result=a*b*c*d;
                Console.WriteLine($"Результат произведения: {result}");
            }
            else 
            {
                Console.WriteLine($"Последовательность не возрастающая");
                Console.WriteLine($"Минимальный из них: {(Math.Min(Math.Min(a,b),Math.Min(c,d)))}");
            }
        }    
    }
}