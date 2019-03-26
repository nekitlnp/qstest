namespace ClassLibrary1
{
    public class FastQuick
    {
        public static void QuickSort(int[] array)
        {
            if (array is null) return;
            Sorting(array, 0, array.Length - 1);
        }
        public static void Sorting(int[] array, int first, int last)
        {
            if (last <= 1) return;
            int p = array[(last - first) / 2 + first];
            int temp;
            int i = first;
            int j = last;

            while (i < j)
            {
                while (array[i] < p && i < last)
                {
                    ++i;
                }

                while (array[j] > p && j > first)
                {
                    --j;
                }

                if (i <= j)
                {

                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    ++i;
                    --j;
                }
            }
            if (j > first)
                Sorting(array, first, j);
            if (i < last)
                Sorting(array, i, last);
        }
    }
}