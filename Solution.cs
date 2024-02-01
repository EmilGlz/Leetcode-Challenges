namespace LeetCode_Challenges
{
    public class Solution
    {
        #region 27. Remove Element
        public int RemoveElement(int[] nums, int val)
        {
            var res = new int[nums.Length];
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    res[k] = nums[i];
                    k++;
                }
            }
            Array.Copy(res, nums, nums.Length);
            return k;
        }
        #endregion

        #region 88. Merge Sorted Array
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int num2IndexCounter = 0;
            int num1IndexCounter = 0;
            var res = new int[m + n];
            for (int i = 0; i < m + n; i++) // first array
            {
                if (m == 0)
                {
                    res = nums2;
                    break;
                }
                else if (n == 0)
                {
                    res = nums1;
                    break;
                }

                if (num2IndexCounter == n || num1IndexCounter < m && nums1[num1IndexCounter] < nums2[num2IndexCounter]) // add from nums1
                {
                    res[i] = nums1[num1IndexCounter];
                    num1IndexCounter++;
                }
                else  // add from nums2
                {
                    res[i] = nums2[num2IndexCounter];
                    num2IndexCounter++;
                }
            }
            Array.Copy(res, nums1, m + n);
        }
        #endregion
    }
}
