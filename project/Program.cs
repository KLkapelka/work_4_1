// Дано целое положительное число n. Вычислите произведение
// натуральных чисел, кратных трём и не превышающим число n;

using System;
class work_4_1
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine()); 
        int number = 1; 

        for(int i = 3; i <= n; i += 3)
        {
            number *= 3; 
            if (number >  n) 
            
                number /= 3; 
                break; 
            }
        }

        Console.WriteLine($"Получившееся число: {number}"); 
    }
} 
