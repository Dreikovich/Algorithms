internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello!");

        int[] nums = [3, 2, 4];
        int target = 6;

        int[] result = TwoSumTask.TwoSum(nums, target);
    }
}
