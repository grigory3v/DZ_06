/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

namespace Task_01
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine($" Введите количество чисел, которое может ввсести пользователь");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            int i = 0;
            Console.WriteLine($" Введите числа");
            for (i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            PrintArray(array);
        }

        public static void PrintArray(int[] array)
        {
            int length = array.Length;
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (array[i] > 0)
                {
                    count++;
                }
            }
            Console.Write($" чисел больше 0  = {count} ");
            Console.WriteLine();
        }

    }
}
