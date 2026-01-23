namespace LeetCode_ProblemSolving.Problem_5
{
    public class Remove_Element
    {
        public int RemoveElement(int[] nums, int val)
        {
            int result = 0;

            if (nums.Length == 0)
                return 0;
            
            if(!nums.Contains(val))
            {
                return nums.Length;
            }

            foreach(var item in nums)
            {
                if(item != val)
                {
                    nums[result] = item;
                    result++;
                }
            }

            return result;
        }
    }
}
