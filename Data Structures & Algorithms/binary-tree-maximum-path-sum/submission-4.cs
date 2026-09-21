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
    int global = int.MinValue;
    public int MaxPathSum(TreeNode root) {

        if(root == null)
            return 0;

        MaxTreeSum(root);

        return global;
        
    }

    public int MaxTreeSum(TreeNode root)
    {
        if(root == null)
            return 0;
        int leftval = Math.Max(0, MaxTreeSum(root.left));
        int rightval = Math.Max(0, MaxTreeSum(root.right));
        global = Math.Max(global, leftval+rightval+root.val);
        return Math.Max(leftval+root.val, rightval+root.val);
    }
}
