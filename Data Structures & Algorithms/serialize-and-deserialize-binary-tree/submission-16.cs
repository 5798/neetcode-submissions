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

public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        if(root==null)
            return "";

        var q = new Queue<TreeNode>();
        var sb = new StringBuilder();

        q.Enqueue(root);

        while(q.Count>0)
        {
            int c = q.Count;
            while(c>0)
            {
                var node = q.Dequeue();
                if(node==null)
                {
                    sb.Append('N');
                }
                else
                {
                    sb.Append(node.val);
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
                sb.Append(',');
                c--;
            }
        }

    return sb.ToString();

    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        if(data.Length==0)
            return null;
        string[] tokens = data.Split(',', StringSplitOptions.RemoveEmptyEntries);
        int i=0;
        var q = new Queue<TreeNode>();
        var head = new TreeNode(int.Parse(tokens[i++]));
        q.Enqueue(head);

        while(q.Count>0)
        {
            int c = q.Count;
            while(c>0)
            {
                var node = q.Dequeue();
                string l = tokens[i++];
                string r = tokens[i++];
                if(l!="N")
                {
                    node.left= new TreeNode(int.Parse(l));
                    q.Enqueue(node.left);
                }
                
                if(r!="N")
                {
                    node.right= new TreeNode(int.Parse(r));
                    q.Enqueue(node.right);
                }
                c--;
            }
        }
        return head;
    }
}
