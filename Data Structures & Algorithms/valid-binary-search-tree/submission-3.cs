/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsValidBST(TreeNode root) {
        int min = int.MinValue;
        int max = int.MaxValue;
        return Validate(root, min, max);
    }

    public bool Validate(TreeNode root, int min, int max)
    {
        if(root==null)
            return true;
        
        if(root.val<=min || root.val>=max)
            return false;
        
        return (Validate(root.left, min, root.val) && Validate(root.right, root.val, max));
    }
}
