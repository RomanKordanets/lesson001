// быстрая сортировка

public static int Partition(int[] Array, int start, int end)
        {
            int temp;//swap helper
            int marker = start;//divides left and right subarrays
            for (int i = start; i <= end; i++)
            {
                if (Array[i] < Array[end]) //array[end] is pivot
                {
                    temp = Array[marker]; // swap
                    Array[marker] = Array[i];
                    Array[i] = temp;
                    marker += 1;
                }
            }
            //put pivot(array[end]) between left and right subarrays
            temp = Array[marker];
            Array[marker] = Array[end];
            Array[end] = temp;
            return marker;
        }
 
        public static void QuickSort(int[] Array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = Partition(Array, start, end);
            QuickSort(Array, start, pivot - 1);
            QuickSort(Array, pivot + 1, end);
        }









public static int Partition1<T>(T[] m, int a, int b) where T : IComparable<T>
        {
            int i = a;
            for (int j = a; j <= b; j++)         // просматриваем с a по b
            {
                if (m[j].CompareTo(m[b]) <= 0)  // если элемент m[j] не превосходит m[b],
                {
                    T t = m[i];                  // меняем местами m[j] и m[a], m[a+1], m[a+2] и так далее...
                    m[i] = m[j];                 // то есть переносим элементы меньшие m[b] в начало,
                    m[j] = t;                    // а затем и сам m[b] «сверху»
                    i++;                         // таким образом последний обмен: m[b] и m[i], после чего i++
                }
            }
            return i - 1;                        // в индексе i хранится <новая позиция элемента m[b]> + 1
        }
 
        public static void QuickSort1<T>(T[] m, int a, int b) where T : IComparable<T>// a - начало подмножества, b - конец
        {                                        // для первого вызова: a = 0, b = <элементов в массиве> - 1
            if (a >= b) return;
            int c = Partition1(m, a, b);
            QuickSort1(m, a, c - 1);
            QuickSort1(m, c + 1, b);
        }

