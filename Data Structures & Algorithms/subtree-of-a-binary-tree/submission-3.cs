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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root ==null)
            return false;
        else if(subRoot == null)
            return true;
        
        if(IsSametree(root, subRoot))
            return true;
        else
            return (IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot));

    }

    public bool IsSametree(TreeNode p, TreeNode q) 
    {
        if(p==null&&q==null)
            return true;
        else if (p==null && q!=null)
            return false;
        else if (p!=null && q==null)
            return false;
        else if (p.val!=q.val)
            return false;
        
        return (IsSametree(p.left, q.left) && IsSametree(p.right, q.right));
    }

}
