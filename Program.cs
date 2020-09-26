using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строчек:");
            int max = 0;
            int n = int.Parse(Console.ReadLine()); //вводим кол-во строк
            int[] R = new int[n]; // создаем массив R 
            Random rnd = new Random();
            Random r = new Random();

            for (int i = 0; i < R.Length; i++)
            {
                R[i] = rnd.Next(1, 9);
            } //случайно задаем размеры строкам

            Console.WriteLine("Размер строк:");


            for (int i = 0; i < R.Length; i++)
            {
                Console.Write(i + " строка = " + R[i] + "; ");
            } //выводим размер строк

            Console.WriteLine();

            int[][] F = new int[n][]; // создаем зубчастую матрицу 

            for (int i = 0; i < R.GetLength(0); i++)
            {
                int a = R[i];
                if (a > max)
                {
                    max = a;
                }
            } // находим максимальное кол-во элементов

            Console.WriteLine("Кол-во столбиков " + max);

            for (int i = 0; i < n; i++)
            {
                F[i] = new int[R[i]];
            } // создаем массивы размерностью i-того элемента массива R

            for (int i = 0; i < F.GetLength(0); i++)
            {
                for (int j = 0; j < F[i].Length; j++)
                {
                    F[i][j] = r.Next(0, 9);
                }
            } //случайно заполняем строки 

            for (int i = 0; i < F.GetLength(0); i++)
            {
                for (int j = 0; j < F[i].Length; j++)
                {
                    Console.Write(F[i][j] + " ");
                }
                Console.WriteLine();
            } // выводим зубчастую матриц 

            Console.WriteLine("Прямоугольная матрицa " + n + "x" + max);
            int[,] H = new int[n, max]; // создаем прямоугольной матрицу 
            Array.Clear(H, n, max);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < F[i].GetLength(0); j++)
                {
                    H[i, j] = F[i][j];
                }
            } //заполняем прямоугольную матрицу

            for (int i = 0; i < H.GetLength(0); i++)
            {
                for (int j = 0; j < max; j++)
                {
                    Console.Write(H[i,j] + " ");
                }
                Console.WriteLine();
            } // выводим прямоугольную матрицу

            Console.WriteLine("Отсортированый масив R:");

            for (int i = 0; i < F.GetLength(0); i++)
                {
                    for (int j = 0; j < F[i].Length; j++)
                    {
                        Array.Sort(F[i]);
                        Array.Reverse(F[i]);
                        Console.Write(F[i][j] + " ");
                    }
                    Console.WriteLine();
                }   //сортируем массив R[i]
        }
    }
}

