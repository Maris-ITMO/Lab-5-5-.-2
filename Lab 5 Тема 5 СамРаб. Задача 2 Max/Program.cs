using System;

namespace Lab_5_Тема_5_СамРаб._Задача_2_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Console.WriteLine("Введите число");
            Random random = new Random();
            int s = 0;
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                s += array[i];
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            foreach (int a in array)
            {
                if (a > max) ;
                max = a;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
