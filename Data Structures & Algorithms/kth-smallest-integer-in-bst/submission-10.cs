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
    int c = 0;
    int ans = 0;
    public int KthSmallest(TreeNode root, int k) {
        if(root==null)
            return 0;

        int x = KthSmallest(root.left, k);

        if(x!=0)
            return x;

        // on visiting
        c++;
        if(k==c)
            return root.val;
            
        x = KthSmallest(root.right, k);

        if(x!=0)
            return x;

        return 0;

    }
}
