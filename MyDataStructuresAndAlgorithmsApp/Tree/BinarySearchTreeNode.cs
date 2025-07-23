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
            throw new MaxChildCountExceededException($"{this.GetType().Name} cannot have more than {this.MaxChildrenCount} children");
        }
        
        // Adding the duplicate child one level down
        var childWithSameValue = this.Children.Where(x => x.Value == newChild.Value).FirstOrDefault();
        if (childWithSameValue != null)
        {
            childWithSameValue.AddChild(newChild);
            return;
        }
    }
}