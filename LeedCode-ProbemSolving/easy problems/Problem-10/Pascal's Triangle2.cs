namespace LeetCode_ProblemSolving.Problem_10
{
    public class Pascal_s_Triangle2
    {
        public IList<int> GetRow(int rowIndex)
        {
            //IList<IList<int>> pascals = new List<IList<int>>();
            //List<int> rowIndexResult = new();

            //for (int i = 0; i <= rowIndex; i++)
            //{
            //    List<int> row = new();

            //    row.Add(1);
            //    for (int j = 1; j < i; j++)
            //    {
            //        var prev = pascals[i - 1];

            //        row.Add(prev[j - 1] + prev[j]);
            //    }

            //    if (i > 0)
            //        row.Add(1);

            //    pascals.Add(row);

            //    rowIndexResult = row;
            //}

            //return rowIndexResult;


            // another mehod
            List<int> rowIndexResult = new();

            for (int i = 0; i <= rowIndex; i++)
            {
                List<int> row = new List<int> { 1 };

                for (int j = 1; j < i; j++)
                {
                    row.Add(rowIndexResult[j - 1] + rowIndexResult[j]);

                }
                
                if(i > 0)
                row.Add(1);

                rowIndexResult = row;
            }

            return rowIndexResult;
        }
    }
}
