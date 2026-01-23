namespace LeetCode_ProblemSolving.Problem_3
{
    public class Valid_Parentheses
    {

 
        public bool IsValid(string s)
        {

            while(s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
            {
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }

            return s.Length == 0;
        }
    }
}
