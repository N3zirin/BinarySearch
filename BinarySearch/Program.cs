namespace AdvancedBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample sorted array
            int[] sortedArray = { 1, 2, 5, 7, 8, 9, 12, 13, 15, 17, 19, 21, 22, 23, 25, 27 };

            Console.WriteLine("Enter the number to search for:");
            if (int.TryParse(Console.ReadLine(), out int target))
            {
                int index = BinarySearch(sortedArray, target);

                if (index != -1)
                {
                    Console.WriteLine($"Number found at index {index}.");
                }
                else
                {
                    Console.WriteLine("Number not found in the array.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        // Binary Search Method
        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                // Check if target is present at mid
                if (array[middle] == target)
                {
                    return middle;
                }

                // If target greater, ignore left half
                if (array[middle] < target)
                {
                    left = middle + 1;
                }
                // If target is smaller, ignore right half
                else
                {
                    right = middle - 1;
                }
            }

            // Target not present in array
            return -1;
        }
    }
}
