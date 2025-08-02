namespace MyDataStructuresAndAlgorithmsApp.Tree;

public class Tree<T>(T rootNode)
    where T : TreeNode
{
    public T RootNode { get; set; } = rootNode;
    protected virtual int MaxChildrenCount { get; private set; } = 3;
    
    public virtual void AddNode(T newNode, T? parentNode = null)
    {
        if (parentNode == null)
        {
            AddNode(newNode, RootNode);
            return;
        }
        
        
        if (parentNode.Children.Count == MaxChildrenCount)
        {
            var childNode = parentNode.Children.OrderBy(x => x.Children.Count).First();
            AddNode(newNode, (T)childNode);
            return;
        }
        
        parentNode.Children.Add(newNode);
        return; 
    }
}