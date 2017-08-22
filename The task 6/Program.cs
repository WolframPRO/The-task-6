using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности: ");
            bool ok;
            int N;

            do
            {
                ok = Int32.TryParse(Console.ReadLine(), out N);
                if (N < 1)
                {
                    Console.WriteLine("Последовательность слишком мала!");
                    ok = false;
                }
                if (!ok) Console.WriteLine("Ошибка ввода длины!");
            } while (!ok);

            Console.WriteLine("Введите три первых члена последовательности через Enter: ");

            double[] mass = new double[N];
            Console.Write("Введите 1 элемент: ");
            do { ok = double.TryParse(Console.ReadLine(), out mass[0]); if (!ok) Console.WriteLine("Ошибка ввода 1 элемента!"); } while (!ok);
            Console.Write("Введите 2 элемент: ");
            do { ok = double.TryParse(Console.ReadLine(), out mass[1]); if (!ok) Console.WriteLine("Ошибка ввода 2 элемента!"); } while (!ok);
            Console.Write("Введите 3 элемент: ");
            do { ok = double.TryParse(Console.ReadLine(), out mass[2]); if (!ok) Console.WriteLine("Ошибка ввода 3 элемента!"); } while (!ok);

            double E;
            Console.Write("Введите Epsilon: ");
            do { ok = double.TryParse(Console.ReadLine(), out E); if (!ok) Console.WriteLine("Ошибка ввода!"); } while (!ok);

            int n = 0;


            Console.Write(mass[0] + " ");
            Console.Write(mass[1] + " ");
            Console.Write(mass[2] + " ");

            for (int i = 3; i < N; i++)
            {
                mass[i] = mass[i - 1] / 3 + mass[i - 2] / 2 + mass[i - 3] * 2 / 3;
                Console.Write(mass[i] + " ");
            }

            for (int i = 1; i < N; i++)
            {
                if (Math.Abs(mass[i] - mass[i - 1]) < E)
                {
                    Console.WriteLine(n + "- удовлетворяет условию");
                    n++;
                }
            }

            Console.WriteLine("Всего верных значений: " + n);

            Console.ReadKey();
        }
    }
}
