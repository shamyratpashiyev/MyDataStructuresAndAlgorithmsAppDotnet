using MyDataStructuresAndAlgorithmsApp.Tree.CustomExceptions;

namespace MyDataStructuresAndAlgorithmsApp.Tree;

public class BinarySearchTree(BinarySearchTreeNode rootNode) : BinaryTree<BinarySearchTreeNode>(rootNode)
{
    public override void AddNode(BinaryTreeNode newNode, BinaryTreeNode? node = null)
    {
        if (node == null)
        {
            AddNode(newNode, RootNode);
        }
        
        try
        {
            if (newNode.Value >= node.Value)
            {
                node.AppendChild(newNode);
            }
            else
            {
                node.PrependChild(newNode);
            }
            return;
        }
        catch (MaxChildCountExceededException)
        {
            foreach (var childNode in node.GetChildren())
            {
                AddNode(newNode, (BinaryTreeNode)childNode);
            }
        }
    }
}