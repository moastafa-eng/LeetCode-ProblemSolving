namespace LeetCode_ProblemSolving.easy_problems.Problem___11
{
    public class Best_Time_to_Buy_and_Sell_Stock
    {
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach(int currentPrice in prices)
            {
                minPrice = Math.Min(currentPrice, minPrice);
                maxProfit = Math.Max(maxProfit, currentPrice - minPrice);
            }

            return maxProfit;
        }
    }
}
