public static class MergeSortedArray
{
    //Backward Merge
    //[1,2,3,0,0,0], nums2 = [2,5,6]

    //0 ms, beats 100%
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int p1 = m - 1;
        int p2 = n - 1;
        int writeidx = m + n - 1;

        while (p2 >= 0)
        {
            if (p1 >= 0 && nums1[p1] > nums2[p2])
            {
                nums1[writeidx] = nums1[p1];
                p1--;
            }
            else
            {
                nums1[writeidx] = nums2[p2];
                p2--;
            }
            writeidx--;
        }
    }

    // 2 ms, beats 12,39%
    public static void Merg2(int[] nums1, int m, int[] nums2, int n)
    {
        int p1 = m + n - 1;
        int p2 = n - 1;
        while (p2 >= 0)
        {
            nums1[p1] = nums2[p2];
            p1--;
            p2--;
        }

        Array.Sort(nums1);
    }
}
