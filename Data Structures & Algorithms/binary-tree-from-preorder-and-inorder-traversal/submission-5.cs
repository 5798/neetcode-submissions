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
    Dictionary<int, int> dir = new Dictionary<int, int>();
    int j=0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {

        if(inorder.Length != preorder.Length)
            return null;
        
        for(int i =0;i<inorder.Length; i++)
        {
            dir[inorder[i]]=i;

        }
        return Build(preorder, 0, inorder.Length-1);


    }

    public TreeNode Build(int[] preorder, int left, int right)
    {
        if(left>right)
            return null;

        var node = new TreeNode(preorder[j]);
        j++;

        var index = dir[node.val];

        node.left = Build(preorder,left, index-1);
        node.right = Build(preorder, index+1, right);

        return node;
    }
}
