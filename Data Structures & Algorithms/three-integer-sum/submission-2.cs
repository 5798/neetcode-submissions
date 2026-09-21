public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var list = new List<List<int>>();
        int left =1;
        int right = nums.Length-1;
        int k = -nums[0];
        for(int i=0; i<nums.Length-2;i++)
        {
            k=-nums[i];
            left=i+1;
            right = nums.Length - 1;
            
            if(i>0 && nums[i] == nums[i-1])
            {
                continue;
            }
            while(left<right)
            {
                if(nums[left]+nums[right]<k)
                {
                    left++;
                }
                else if(nums[left]+nums[right]>k)
                {
                    right--;
                }
                else if(nums[left]+nums[right]==k)
                {
                    list.Add(new List<int>{-k, nums[left], nums[right]});
                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1])
                    {
                        left++;
                    }

                    while (left < right && nums[right] == nums[right + 1])
                    {
                        right--;
                    }
                }
            }
        }
        return list;
    }
}
