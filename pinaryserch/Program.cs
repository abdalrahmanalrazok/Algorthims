namespace algorthims
{
    internal class Program
    {
        static int punarysrech(int[] ary, int target)
        {
            int low = 0, high = ary.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (ary[mid] == target) return mid;
                if (ary[mid] < target) low = mid + 1;
                else high = mid - 1;
            }
            return -1;

        }
        static void Main(string[] args)
        {
            Console.WriteLine($"This is targer {punarysrech([1, 6, 9], 9)}");
        }
    }
}
