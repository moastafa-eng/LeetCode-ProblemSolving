namespace LeetCode_ProblemSolving.easy_problems.Problem_12
{
    public class SingleNumber
    {
        public int SingleNumberr(int[] nums)
        {
            int output = 0;

            foreach(int n in nums)
            {
                output = n ^ output;
            }

            return output;
        }
    }
}
