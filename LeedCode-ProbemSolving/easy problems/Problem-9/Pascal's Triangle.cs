namespace LeetCode_ProblemSolving.Problem_9
{
    public class Pascal_s_Triangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> pascals = new List<IList<int>>();

            for(int i = 0; i < numRows; i++)
            {
                List<int> row = new();

                row.Add(1);
                for (int j = 1; j < i; j++)
                {
                    var prev = pascals[i - 1];

                    row.Add(prev[j - 1] + prev[j]);
                }

                if (i > 0)
                    row.Add(1);

                pascals.Add(row);
            }

            return pascals;
        }
    }
} 
