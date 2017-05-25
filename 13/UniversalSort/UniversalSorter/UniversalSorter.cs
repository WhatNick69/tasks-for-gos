using System;
using System.Threading.Tasks;

public class UniversalSorter
{
    /// <summary>
    /// Быструю сортировку (последовательные)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="arr"></param>
    public static void QuicksortSequential<T>(T[] arr) where T : IComparable<T>
    {
        QuicksortSequential(arr, 0, arr.Length - 1);
    }

    /// <summary>
    /// Быструю сортировку (параллельные)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="arr"></param>
    public static void QuicksortParallel<T>(T[] arr) where T : IComparable<T>
    {
        QuicksortParallel(arr, 0, arr.Length - 1);
    }

    /// <summary>
    /// Сортировку вставкой (последовательные)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="arr"></param>
    public static void InsertionSortSequential<T>(T[] arr) where T : IComparable<T>
    {
        InsertionSortSequential(arr, 0, arr.Length - 1);
    }

    /// <summary>
    /// Сортировку вставкой (параллельные)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="arr"></param>
    public static void InsertionSortParallel<T>(T[] arr) where T : IComparable<T>
    {
        InsertionSortParallel(arr, 0, arr.Length - 1);
    }

    private static void InsertionSortSequential<T>(T[] array, int from, int to) where T : IComparable<T>
    {
        for (int i = from + 1; i < to; i++)
        {
            var a = array[i];
            int j = i - 1;

            while (j >= from && array[j].CompareTo(a) == -1)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = a;
        }
    }

    private static void InsertionSortParallel<T>(T[] array, int from, int to) where T : IComparable<T>
    {
        Parallel.For(from + 1, to, i =>
        {
            var a = array[i];
            int j = i - 1;

            while (j >= from && array[j].CompareTo(a) == -1)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = a;
        });
    }

    private static void QuicksortSequential<T>(T[] arr, int left, int right) where T : IComparable<T>
    {
        if (right <= left) return;
        int pivot = Partition(arr, left, right);
        QuicksortSequential(arr, left, pivot - 1);
        QuicksortSequential(arr, pivot + 1, right);
    }

    private static void QuicksortParallel<T>(T[] arr, int left, int right) where T : IComparable<T>
    {
        if (right <= left) return;
        if (right - left < 2048)
        {
            QuicksortSequential(arr, left, right);
        }
        else
        {
            int pivot = Partition(arr, left, right);
            Parallel.Invoke(new Action[] { delegate {QuicksortParallel(arr, left, pivot - 1);},
                    delegate {QuicksortParallel(arr, pivot + 1, right);}
                });
        }
    }

    private static void Swap<T>(T[] arr, int i, int j)
    {
        T tmp = arr[i];
        arr[i] = arr[j];
        arr[j] = tmp;
    }

    private static int Partition<T>(T[] arr, int low, int high) where T : IComparable<T>
    {
        int pivotPos = (high + low) / 2;
        T pivot = arr[pivotPos];
        Swap(arr, low, pivotPos);

        int left = low;
        for (int i = low + 1; i <= high; i++)
        {
            if (arr[i].CompareTo(pivot) >= 0) continue;
            left++;
            Swap(arr, i, left);
        }

        Swap(arr, low, left);
        return left;
    }
}

