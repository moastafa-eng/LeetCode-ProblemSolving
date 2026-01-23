using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_ProblemSolving.Problem_6
{
    public class Search_Insert_Position
    {
        public int SearchInsert(int[] nums, int target)
        {
            #region Method one
            //int index = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (target == nums[i])
            //    {
            //        index = i;
            //        break;
            //    }
            //    else
            //    {
            //        if (!nums.Contains(target) && target > nums[nums.Length - 1])
            //        {
            //            index = nums.Length;
            //            break;
            //        }
            //        else
            //        {
            //            if (target > nums[i] && target < nums[i + 1] && !nums.Contains(target))
            //            {
            //                index = ++i;
            //                break;
            //            }
            //        }
            //    }
            //}

            //return index; 
            #endregion

            // another method 

            int length = nums.Length;

            for (int i = 0; i < length; i++) 
            {
                if (nums[i] >= target)
                {
                    return i;
                }
            }

            return length;
        }

    }
}
