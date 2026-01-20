namespace LeetCode_ProblemSolving.Problem_2
{
    public class Set_Mismatch
    {
        public int[] FindErrorNums(int[] nums)
        {
            int container = 0;
            int[] numbers = new int[2];

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[0] != 1)
                {
                    numbers[0] = 2;
                    numbers[1] = 1;

                    return numbers;
                }

                if(container == nums[i])
                {
                    numbers[0] = container;
                    if (nums[i] - 1 != nums[i - 2])
                        numbers[1] = container - 1;
                    else
                        numbers[1] = container + 1;
                }
                else
                {
                    container = nums[i];
                }
            }

            return numbers;
        }
    }
}
