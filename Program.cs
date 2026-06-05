internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello!");

        int[] nums = [4, 3, 2, 7, 8, 2, 3, 1];

        FindDisappeared.FindDisappearedNumbers(nums);

        GroupAnagrams.Group(["eat", "tea", "tan", "ate", "nat", "bat"]);

        TopKFrequent.FindTopKFrequent([1, 1, 1, 2, 2, 3], 2);
    }
}
