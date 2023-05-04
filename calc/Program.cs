using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, choice;
            Console.WriteLine("Введите числа А и В:");
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 1, чтобы сложить, 2 - отнять, 3 - умножить  4 - разделить");
            choice = Convert.ToInt32(Console.ReadLine());      

            switch (choice)
            {
                case 1:
                    int sum = A + B;
                    Console.WriteLine($"сумма:{sum}");
                    break;
                case 2:
                    int sub = A - B;
                    Console.WriteLine($"разность:{sub}");
                    break;
                case 3:
                    int mul = A * B;
                    Console.WriteLine($"произведение:{mul}");
                    break;

                case 4:
                    int del = A / B;
                    Console.WriteLine($"частное:{del}");
                    break;
            }
        }
    }
}
