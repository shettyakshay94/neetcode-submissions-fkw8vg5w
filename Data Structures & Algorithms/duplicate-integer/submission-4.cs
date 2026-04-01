public class Solution {
    public bool hasDuplicate(int[] nums) {
   HashSet<int> uniquenums = new HashSet<int>();
   for (int i =0;i<nums.Length;i++)
   {
    if(uniquenums.Contains(nums[i]))
    return true;
    uniquenums.Add(nums[i]);
   }
   return false;     
}
}
