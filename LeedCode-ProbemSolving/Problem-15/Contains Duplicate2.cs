namespace LeetCode_ProblemSolving.Problem_15
{
    public class Contains_Duplicate2
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {

            // Sliding Window Technique.
            var window = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > k)
                    window.Remove(nums[i - k - 1]);

                // if num[i] is exist in range k elements return true if not return false.
                if (!window.Add(nums[i]))
                    return true;
            }

            return false;
        }
    }
}
