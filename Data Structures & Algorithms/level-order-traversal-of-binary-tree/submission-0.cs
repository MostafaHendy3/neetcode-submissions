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
        List<List<int>> res =new();
        Queue<TreeNode> queue =new();

        queue.Enqueue(root);
        while(queue.Count>0){
            List<int> level = new();
            for (int i = queue.Count; i > 0; i--) {
                TreeNode node = queue.Dequeue();
                if(node!=null){
                    level.Add(node.val);
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }
            if(level.Count >0){
                    res.Add(level);
                }
        }
        return res;

    }
}
