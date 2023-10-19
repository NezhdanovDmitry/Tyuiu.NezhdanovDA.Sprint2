using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NezhdanovDA.Sprint2.Task0.V8.Lib;

namespace Tyuiu.NezhdanovDA.Sprint2.Task0.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Cпринт #1 | Выполнил: Нежданов Д. А. | СМАРT6-23-1";


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Cпринт #2                                                                  *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющей структуры                                    *");
            Console.WriteLine("* Задание #0                                                                 *");
            Console.WriteLine("* Вариант #2                                                                 *");
            Console.WriteLine("* Выполнил: Нежданов Дмитрий Алексеевич | СМАРT6-23-1                        *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, из операций сравнений и арифметических выражений,      *");
            Console.WriteLine("* которая вернет логическую последовательность(массив).                       *");
            Console.WriteLine("*                                                                            *");


            int x = 185;
            int y = 251;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("X= " + x);
            Console.WriteLine("Y= " + y);

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
