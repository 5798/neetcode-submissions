public class Solution {
public int LongestConsecutive(int[] nums) {
    var h = new HashSet<int>(nums);
    int max=0;
    int counter=0;
    int i=0;
    int start=0;

    while(i<nums.Length)
    {
        if(!h.Contains(nums[i]-1))
        {
            start = nums[i];
            counter =0;
            while(h.Contains(start))
            {
                counter++;
                start++;
            }
        }
        
        i++;
        if(counter>max)
            max=counter;
    }
    return max;
}
}
