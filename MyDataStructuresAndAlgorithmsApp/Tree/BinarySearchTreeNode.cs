using MyDataStructuresAndAlgorithmsApp.Tree.CustomExceptions;

namespace MyDataStructuresAndAlgorithmsApp.Tree;

public class BinarySearchTreeNode : BinaryTreeNode
{
    public BinarySearchTreeNode(int value) : base(value){ }
    
    protected override int MaxChildrenCount => 2;
    
    public override void AddChild(TreeNode newChild)
    {
        if (GetChildren().Count == MaxChildrenCount)
        {
            throw new MaxChildCountExceededException("BinarySearchTreeNode cannot have more than two children");
        }
        
        // Adding the duplicate child one level down
        var childWithSameValue = GetChildren().Where(x => x.GetValue() == newChild.GetValue()).FirstOrDefault();
        if (childWithSameValue != null)
        {
            childWithSameValue.AddChild(newChild);
            return;
        }
        
        if (newChild.GetValue() >= this.GetValue())
        {
            this.Children = this.Children.Append(newChild).ToList();
        }
        else
        {
            this.Children = this.Children.Prepend(newChild).ToList();
        }
    }
}