namespace MyDataStructuresAndAlgorithmsApp.Tree;

public class RootedTreeNode
{
    public RootedTreeNode(int value)
    {
        Value = value;
        Children = new();
    }
    private int Value { get; set; }
    
    private List<RootedTreeNode> Children { get; set; }
    
    public int GetValue()
    {
        return this.Value;
    }
    
    public void SetValue(int value)
    {
        this.Value = value;
    }
    
    public List<RootedTreeNode> GetChildren()
    {
        return this.Children;
    }
    
    public virtual void AddChild(RootedTreeNode child)
    {
        this.Children.Add(child);
    }
    
    public void RemoveChild(RootedTreeNode child)
    {
        this.Children.Remove(child);
    }
    
    public void SortChildren(bool descending = false)
    {
        this.Children = descending ?
            Children.OrderByDescending(x => x.Value).ToList() :
            Children.OrderByDescending(x => x.Value).ToList();
    }
}