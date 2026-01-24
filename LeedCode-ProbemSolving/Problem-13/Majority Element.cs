namespace LeetCode_ProblemSolving.Problem_13
{
    public class Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            // Time complexity = O(n log n)
            //Array.Sort(nums);

            //return nums[nums.Length / 2];


            // Time complexity = O(n).
            int majority = 0;
            int count = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                    majority = nums[i];

                if (nums[i] == majority)
                    count++;
                else
                    count--;

            }

            return majority;
        }
    }
}
