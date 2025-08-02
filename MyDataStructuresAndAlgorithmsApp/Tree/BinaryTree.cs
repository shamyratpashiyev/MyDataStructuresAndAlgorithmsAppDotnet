namespace MyDataStructuresAndAlgorithmsApp.Tree;

public class BinaryTree<T>(BinaryTreeNode rootNode) : Tree<BinaryTreeNode>(rootNode) where T : BinaryTreeNode
{
    protected override int MaxChildrenCount => 2;
}