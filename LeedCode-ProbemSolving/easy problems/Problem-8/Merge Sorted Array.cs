namespace LeetCode_ProblemSolving.Problem_8
{
    public class Merge_Sorted_Array
    {
        //public void Merge(int[] nums1, int m, int[] nums2, int n)
        //{
        //    if(m == 0)
        //        for(int i = 0; i < n; i++)
        //        {
        //            nums1[i] = nums2[i];
        //        }

        //    else
        //    {
        //        if(n > 0 && m > 0)
        //        {
        //            int k = 0;
        //            for (int i = m; i < m + n; i++)
        //            {
        //                nums1[i] = nums2[k];
        //                k++;
        //            }

        //            int temp = 0;
        //            for (int i = 0; i < (m + n) - 1; i++)
        //            {
        //                for (int j = 0; j < (m + n) - 1 - i; j++)
        //                {
        //                    if (nums1[j] > nums1[j + 1])
        //                    {
        //                        temp = nums1[j];
        //                        nums1[j] = nums1[j + 1];
        //                        nums1[j + 1] = temp;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        // ++ another method ++
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
             if (n == 0) return;
            int len1 = nums1.Length;
            int end_idx = len1 - 1;
            while (n > 0 && m > 0)
            {
                if (nums2[n - 1] >= nums1[m - 1])
                {
                    nums1[end_idx] = nums2[n - 1];
                    n--;
                }
                else
                {
                    nums1[end_idx] = nums1[m - 1];
                    m--;
                }
                end_idx--;
            }
            while (n > 0)
            {
                nums1[end_idx] = nums2[n - 1];
                n--;
                end_idx--;
            }
        }

    }
}
