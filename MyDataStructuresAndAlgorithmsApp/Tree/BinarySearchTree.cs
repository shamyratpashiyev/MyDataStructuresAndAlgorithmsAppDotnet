namespace MyDataStructuresAndAlgorithmsApp.Tree;

public class BinarySearchTree(BinarySearchTreeNode rootNode) : BinaryTree<BinarySearchTreeNode>(rootNode)
{
    public override void AddNode(BinaryTreeNode newNode, BinaryTreeNode? node = null)
    {
        if (node == null)
        {
            AddNode(newNode, RootNode);
        }
        
        // Adding the newNode to childNode if MaxChildrenCount is already reached
        if (node.Children.Count == MaxChildrenCount)
        {
            foreach (var childNode in node.Children)
            {
                AddNode(newNode, (BinaryTreeNode)childNode);
            }
        }
        
        // Adding the duplicate child one level down
        var childWithSameValue = node.Children.Where(x => x.Value == newNode.Value).FirstOrDefault();
        if (childWithSameValue != null)
        {
            childWithSameValue.Children.Add(newNode);
            return;
        }
        
        if (newNode.Value >= node.Value)
        {
            node.Children = node.Children.Append(newNode).ToList();
        }
        else
        {
            node.Children = node.Children.Prepend(newNode).ToList();
        }
        return;
    }
}