namespace DataStructures
{
    public class Sorting
    {
        public static int[] BubbleSort(int[] array)
        {
            for (int wall = array.Length - 1; wall >= 0; wall--)
            {
                for (int i = 0; i < wall; i++)
                {
                    if (array[i] > array[i + 1])
                        Swap(array, i, i + 1);
                }
            }

            return array;
        }

        private static void Swap(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex == rightIndex) return;

            var temp = array[rightIndex];
            array[rightIndex] = array[leftIndex];
            array[leftIndex] = temp;
        }
    }
}
