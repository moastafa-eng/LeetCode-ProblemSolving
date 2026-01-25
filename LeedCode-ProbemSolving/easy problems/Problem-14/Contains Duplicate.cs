namespace LeetCode_ProblemSolving.easy_problems.Problem_14
{
    public class Contains_Duplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            // O(n)
            HashSet<int> hashSet = new();

            foreach (int item in nums)
            {
                if (!hashSet.Add(item)) return true;
            }

            return false;

            #region O(n log n)
            //if (nums.Length <= 1)
            //    return false;

            //int count = 0;
            //int currentNumber = 0;

            //Array.Sort(nums);

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (count == 0)
            //        currentNumber = nums[i];

            //    if (currentNumber == nums[i])
            //    {
            //        count++;
            //        if (count >= 2)
            //            return true;
            //    }
            //    else
            //    {
            //        currentNumber = nums[i];
            //        i--;
            //        count = 0;
            //    }
            //}

            //return false;

            #endregion

            #region ** Time Limit Exceeded **
            //if (nums.Length <= 1)
            //    return false;

            //int count = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i; j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j])
            //            count++;

            //        if (count > 1)
            //            return true;
            //    }

            //    count = 0;
            //}

            //return false; 
            #endregion

        }

    }
}
