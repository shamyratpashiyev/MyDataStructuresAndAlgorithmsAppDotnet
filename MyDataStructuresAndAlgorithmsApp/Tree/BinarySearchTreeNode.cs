namespace MyDataStructuresAndAlgorithmsApp.Tree;

public class BinarySearchTreeNode : BinaryTreeNode
{
    public BinarySearchTreeNode(int value) : base(value){ }
    
    public void AddChild(BinarySearchTreeNode node)
    {
        if (GetChildren().Count == 2)
        {
            throw new Exception("BinarySearchTreeNode cannot have more than two children");
        }
        
        // Adding the rightChild
        if (node.GetValue() >= this.GetValue())
        {
            if (GetChildren().Count == 0)
            {
                base.AddChild(null);
                base.AddChild(node);
            }
            else
            {
                base.AddChild(node);
                base.SortChildren(descending: true);
            }
        }
        // Adding the leftChild
        else
        {
            if (GetChildren().Count == 0)
            {
                base.AddChild(node);
                base.AddChild(null);
            }
            else
            {
                base.AddChild(node);
                base.SortChildren();
            }
        }
    }
}