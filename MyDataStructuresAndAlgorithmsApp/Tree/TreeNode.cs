namespace MyDataStructuresAndAlgorithmsApp.Tree;

public class TreeNode
{
    public TreeNode(int value)
    {
        Value = value;
        Children = new();
    }
    public int Value { get; private set; }
    
    public List<TreeNode> Children { get; set; }
}