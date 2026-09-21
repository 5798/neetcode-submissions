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
    public List<List<int>> LevelOrder(TreeNode root) {
        var q = new Queue<TreeNode>();
        var list = new List<List<int>>();

        if(root ==null)
            return list;
        
        q.Enqueue(root);

        while(q.Count>0)
        {
            int count = q.Count; 
            var l = new List<int>();
            for(int i =0; i<count; i++)
            {
                var node = q.Dequeue();
                l.Add(node.val);
                if(node.left !=null )
                    q.Enqueue(node.left);
                if(node.right !=null )
                    q.Enqueue(node.right);
            }
            list.Add(l);
        }
        return list;
    }
}
