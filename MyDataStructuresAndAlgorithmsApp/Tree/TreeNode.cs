using MyDataStructuresAndAlgorithmsApp.Tree.CustomExceptions;

namespace MyDataStructuresAndAlgorithmsApp.Tree;

public class TreeNode
{
    public TreeNode(int value)
    {
        Value = value;
        Children = new();
    }
    public int Value { get; protected set; }
    
    protected virtual int MaxChildrenCount { get; private set; } = 3;


    protected List<TreeNode> Children { get; set; }
    
    public int GetValue()
    {
        return this.Value;
    }
    
    public void SetValue(int value)
    {
        this.Value = value;
    }
    
    public List<TreeNode> GetChildren()
    {
        return Children;
    }
    
    public virtual void AddChild(TreeNode newChild)
    {
        if (GetChildren().Count == MaxChildrenCount)
        {
            throw new MaxChildCountExceededException($"{this.GetType().Name} cannot have more than {this.MaxChildrenCount} children");
        }
        
        Children.Add(newChild);
    }
    
    public void RemoveChild(TreeNode child)
    {
        this.Children.Remove(child);
    }
    
    public void AppendChild(TreeNode newChild)
    {
        if (GetChildren().Count == MaxChildrenCount)
        {
            throw new MaxChildCountExceededException($"{this.GetType().Name} cannot have more than {this.MaxChildrenCount} children");
        }

        this.Children = this.Children.Append(newChild).ToList();
    }
    
    public void PrependChild(TreeNode newChild)
    {
        if (GetChildren().Count == MaxChildrenCount)
        {
            throw new MaxChildCountExceededException($"{this.GetType().Name} cannot have more than {this.MaxChildrenCount} children");
        }

        this.Children = this.Children.Prepend(newChild).ToList();
    }
    
    public void SortChildren(bool descending = false)
    {
        this.Children = descending ?
            Children.OrderByDescending(x => x.Value).ToList() :
            Children.OrderBy(x => x.Value).ToList();
    }
}