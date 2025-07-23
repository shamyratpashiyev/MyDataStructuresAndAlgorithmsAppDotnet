namespace MyDataStructuresAndAlgorithmsApp.Tree;

public class BinaryTreeNode : TreeNode
{
    public BinaryTreeNode(int value) : base(value) {}
    
    protected override int MaxChildrenCount => 2;
}