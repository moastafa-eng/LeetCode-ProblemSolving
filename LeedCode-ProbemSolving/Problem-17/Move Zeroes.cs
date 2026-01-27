namespace LeetCode_ProblemSolving.Problem_17
{
    public class Move_Zeroes
    {
        public void MoveZeroes(int[] nums)
        {
            int lengthOfNums = nums.Length;

            if (lengthOfNums < 2)
                return;

            int temp = 0;
            int left = 0;

            for(int right = 0; right < lengthOfNums; right++)
            {
                if (nums[right] != 0)
                {
                    temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;

                    left++;
                }
            }
        }
    }
}
