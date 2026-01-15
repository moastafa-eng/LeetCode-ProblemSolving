namespace LeetCode_ProblemSolving.Problem_1
{
    public class Max_Consecutive_Ones
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {

            int count = 0;
            int container = 0;

            for(int i =0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    count++;
                else
                {
                    if (container < count)
                        container = count;

                    count = 0;
                }
            }

            if (count > container)
                return count;
            else
                return container;
        }
    }
}
