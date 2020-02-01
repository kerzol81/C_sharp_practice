namespace SearchingAlgorithms
{
    class SearchingTools
    {
        public static int BinarySearchI(int[] array, int target)
        {
            // time complexity : O(logn)
            // space complexity : O(1)

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (array[middle] == target)
                {
                    return middle;
                }
                if (target < array[middle])         // target is in the left partition,
                {
                    right = middle - 1;             // update right pointer
                }
                else
                {
                    left = middle + 1;
                }
            }
            return -1;
        }
        
        public static int BinarySearchR(int[] array, int target)
        {
            return BinarySearchR(array, target, 0, array.Length - 1);
        }
        private static int BinarySearchR(int[] array, int target, int left, int right)
        {
            if (right < left)
            {
                return -1;
            }

            int middle = (left + right) / 2;

            if (array[middle] == target)
            {
                return middle;
            }
            if (target < array[middle])
            {
                return BinarySearchR(array, target, left, middle - 1);
            }
            return BinarySearchR(array, target, middle + 1, right);
        }
    }
}
