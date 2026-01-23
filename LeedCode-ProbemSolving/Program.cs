using LeetCode_ProblemSolving.Problem_3;
using LeetCode_ProblemSolving.Problem_1;
using LeetCode_ProblemSolving.Problem_2;
using LeetCode_ProblemSolving.Problem_4;
using LeetCode_ProblemSolving.Problem_5;
using LeetCode_ProblemSolving.Problem_6;
using LeetCode_ProblemSolving.Problem_7;
using LeetCode_ProblemSolving.Problem_8;
using LeetCode_ProblemSolving.Problem_9;

namespace LeetCode_ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Max Consecutive Ones
            //int[] nums = [0, 1, 1, 1, 0, 1, 1];
            //Max_Consecutive_Ones maxConsecutive = new();

            //Console.WriteLine($"The Max consecutive one is : {maxConsecutive.FindMaxConsecutiveOnes(nums)}"); 
            #endregion

            #region 2.Set Mismatch
            //    int[] nums = [1, 4, 4];

            //    Set_Mismatch setMismatch = new();

            //    Console.WriteLine($"The duplicated number and the missing number are : [{setMismatch.FindErrorNums(nums)[0]}, {setMismatch.FindErrorNums(nums)[1]}]");
            //} 
            #endregion

            #region 3.Valid Parentheses

            //Valid_Parentheses validParentheses = new();

            //Console.WriteLine(validParentheses.IsValid("[((})]")); 
            #endregion

            #region 4.Remove Duplicates from Sorted Array

            //Remove_Duplicates_from_Sorted_Array remove_Duplicates_from_Sorted_Array = new();
            //int[] nums = { 1, 1, 2 };

            //Console.WriteLine(remove_Duplicates_from_Sorted_Array.RemoveDuplicates(nums)); 
            #endregion

            #region 5.Remove Element
            //Remove_Element removeElement = new();
            //int[] nums = { 3, 2, 2, 3 };

            //Console.WriteLine(removeElement.RemoveElement(nums, 3)); 
            #endregion

            #region 6.Search Insert Position
            //Search_Insert_Position searchInsertPosition = new();
            //int[] nums = { 2, 3, 4, 7, 8, 9 };

            //Console.WriteLine(searchInsertPosition.SearchInsert(nums, 11)); 
            #endregion

            #region 7.Plus One
            //Plus_One plusOne = new();
            //int[] digits = { 1,2,3};

            //plusOne.PlusOne(digits); 
            #endregion

            #region 8.Merge Sorted Array
            //Merge_Sorted_Array mergeSortedArray = new();
            //int[] nums1 = { 4, 0, 0, 0, 0, 0 };
            //int[] nums2 = { 1, 2, 3, 5, 6 };
            //int m = 1;
            //int n = 5;
            //mergeSortedArray.Merge(nums1, m, nums2, n); 
            #endregion

            Pascal_s_Triangle pascals = new();

            pascals.Generate(5);

        }

    }
}
