namespace LeetCode_ProblemSolving.Problem_15
{
    public class Contains_Duplicate2
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            int I = 0;
            int J = 0;

            HashSet<int> hashSet = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!hashSet.Add(nums[i]))
                {
                    J = i;

                    
                }
            }
            
        }
    }
}
