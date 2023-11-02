namespace DataStructures
{
    public static class BinarySearch
    {
        public static int SearchIterable(int[] array, int value)
        {
            int low = 0;
            int high = array.Length;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (array[mid] ==  value)
                    return mid;
                else if (array[mid] < value)
                    low = mid + 1;
                else
                    high = mid;
            }
            return -1;
        }

        public static int SearchRecursively(int[] array, int value)
        {
            return InternalRecursiveSearch(0, array.Length);

            int InternalRecursiveSearch(int low, int high)
            {
                if (low >= high) return -1;

                int mid = (low + high) / 2;

                if (array[mid] == value)
                    return mid;
                else if (array[mid] < value)
                    return InternalRecursiveSearch(mid + 1, high);
                else
                    return InternalRecursiveSearch(low, mid);
            }
        }
    }
}
