using MyDataStructuresAndAlgorithmsApp.Tree.CustomExceptions;

namespace MyDataStructuresAndAlgorithmsApp.Tree;

public class Tree<T>(T rootNode)
    where T : TreeNode
{
    public T RootNode { get; set; } = rootNode;
    
    public void AddNode(T newNode, T? node = null)
    {
        if (node == null)
        {
            AddNode(newNode, RootNode);
        }
        
        try
        {
            node.AddChild(newNode);
            return;
        }
        catch (MaxChildCountExceededException)
        {
            foreach (var childNode in node.GetChildren())
            {
                AddNode(newNode, (T)childNode);
            }
        }
    }
}