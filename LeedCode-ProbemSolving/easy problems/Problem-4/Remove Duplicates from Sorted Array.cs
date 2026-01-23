namespace LeetCode_ProblemSolving.Problem_4
{
    public class Remove_Duplicates_from_Sorted_Array
    {
        public int RemoveDuplicates(int[] nums)
        {
            int number = 0;

            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[number] != nums[i])
                {
                    nums[++number] = nums[i];
                }
            }

            return ++number;
        }
    }
}
