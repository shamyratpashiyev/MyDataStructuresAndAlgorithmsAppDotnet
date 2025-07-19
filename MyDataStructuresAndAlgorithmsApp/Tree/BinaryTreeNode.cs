namespace MyDataStructuresAndAlgorithmsApp.Tree;

public class BinaryTreeNode : RootedTreeNode
{
    public BinaryTreeNode(int value) : base(value) {}
    
    public virtual void AddChild(BinaryTreeNode child)
    {
        if (GetChildren().Count == 2)
        {
            throw new Exception("BinaryTreeNode cannot have more than two children");
        }
        base.AddChild(child);
    }
}