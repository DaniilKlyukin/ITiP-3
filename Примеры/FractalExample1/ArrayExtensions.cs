using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public static class ArrayExtensions
    {
        public static double Min(this double[,] m)
        {
            var min = double.MaxValue;

            Parallel.For(0, m.GetLength(0), i =>
                {
                    for (int j = 0; j < m.GetLength(1); j++)
                    {
                        if (m[i, j] < min)
                            min = m[i, j];
                    }
                });
            return min;
        }

        public static double Max(this double[,] m)
        {
            var max = double.MinValue;

            Parallel.For(0, m.GetLength(0), i =>
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i, j] > max)
                        max = m[i, j];
                }
            });
            return max;
        }

        public static int Min(this int[,] m)
        {
            var min = int.MaxValue;

            Parallel.For(0, m.GetLength(0), i =>
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i, j] < min)
                        min = m[i, j];
                }
            });
            return min;
        }

        public static int Max(this int[,] m)
        {
            var max = int.MinValue;

            Parallel.For(0, m.GetLength(0), i =>
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i, j] > max)
                        max = m[i, j];
                }
            });
            return max;
        }
    }
}
