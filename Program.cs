using System;
using static System.Console;

namespace half_sort
{
    class Program
    {
        static void QuickSortUp(double[] arr, int first, int last)
        {
            double p = arr[(last - first) / 2 + first];
            double temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < p && i <= last) ++i;
                while (arr[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) QuickSortUp(arr, first, j);
            if (i < last) QuickSortUp(arr, i, last);
        }
        static void QuickSortDown(double[] arr, int first, int last)
        {
            double p = arr[(last - first) / 2 + first];
            double temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (arr[i] > p && i <= last) ++i;
                while (arr[j] < p && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) QuickSortDown(arr, first, j);
            if (i < last) QuickSortDown(arr, i, last);
        }
        static void HalfSort(double[] arr, int first, int last)
        {
            int middle = (last - first) / 2;
            QuickSortUp(arr, first, middle);
            QuickSortDown(arr, middle + 1, last);
        }
        static void Main(string[] args)
        {
            double[] array = { 10, 4, 2, 14, 67, 2, 11, 33, 1, 15 };
            HalfSort(array, 0, 9);
            foreach (var item in array)
            {
                Write($"{item} ");
            }
        }
    }
}
