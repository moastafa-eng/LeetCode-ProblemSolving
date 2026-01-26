namespace LeetCode_ProblemSolving.Problem_16
{
    public class Summary_Ranges
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            List<string> range = new();

            if (nums.Length == 0 || nums == null)
                return range;

            int start = nums[0];
            int end = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
             
                if (nums[i] == end + 1)
                {
                    end = nums[i];
                }
                else
                {
                    range.Add(start == end ? $"{start}" : $"{start}->{end}");
                    start = end = nums[i];
                }
                
            }


            range.Add(start == end ? $"{start}" : $"{start}->{end}");
            
            return range;
        }

    }
}
