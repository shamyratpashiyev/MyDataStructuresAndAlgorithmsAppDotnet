namespace MyDataStructuresAndAlgorithmsApp.Tree;

public class BinaryTree<T>(T rootNode) where T : BinaryTreeNode
{
    public T RootNode { get; set; } = rootNode;

    public virtual void AddNode(T newNode, T? parentNode = null)
    {
        if (parentNode == null)
        {
            AddNode(newNode, RootNode);
            return;
        }
        
        if (parentNode.LeftChild == null || parentNode.RightChild == null)
        {
            if (parentNode.LeftChild == null)
            {
                parentNode.LeftChild = newNode;
            }
            else if (parentNode.RightChild == null)
            {
                parentNode.RightChild = newNode;
            }
            return;
        }
        else
        {
            var childNode = GetHighestNodeWithNoChild(parentNode, 0);
            
            if (childNode.node?.LeftChild == null)
            {
                childNode.node.LeftChild = newNode;
            }
            else if (childNode.node?.RightChild == null)
            {
                childNode.node.RightChild = newNode;
            }
            return;
        }
    }
    
    private (T node, int depth) GetHighestNodeWithNoChild(T parentNode, int depth)
    {
        if (parentNode.LeftChild == null || parentNode.RightChild == null)
        {
            return (parentNode, depth);
        }
        else
        {
            var list = new List<(T node, int depth)>()
            {
                GetHighestNodeWithNoChild((T)parentNode.LeftChild, depth + 1),
                GetHighestNodeWithNoChild((T)parentNode.RightChild, depth + 1)
            };

            return list.OrderBy(x => x.depth).First();
        }
    }
}