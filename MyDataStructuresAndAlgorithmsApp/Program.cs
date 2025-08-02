// See https://aka.ms/new-console-template for more information

using MyDataStructuresAndAlgorithmsApp;
using MyDataStructuresAndAlgorithmsApp.Tree;

public class Program
{
    public static void Main(string[] args)
    {
        // new SimpleDataStructuresExample();
        // new SortingAlgorithmsExample();
        
        var newList = new List<BinaryTreeNode>()
        {
            new BinaryTreeNode(42),
            new BinaryTreeNode(17),
            new BinaryTreeNode(63),
            new BinaryTreeNode(8),
            new BinaryTreeNode(95),
            new BinaryTreeNode(34),
            new BinaryTreeNode(76),
            new BinaryTreeNode(21),
            new BinaryTreeNode(59),
            new BinaryTreeNode(3),
            new BinaryTreeNode(88),
            new BinaryTreeNode(14),
            new BinaryTreeNode(70),
            new BinaryTreeNode(27),
            new BinaryTreeNode(90),
            new BinaryTreeNode(11),
            new BinaryTreeNode(68),
            new BinaryTreeNode(52),
            new BinaryTreeNode(36),
            new BinaryTreeNode(7),
        };
        var binaryTree = new BinaryTree<BinaryTreeNode>(new BinaryTreeNode(50));
        foreach (var binaryTreeNode in newList)
        {
            binaryTree.AddNode(binaryTreeNode);
        }
        
        Console.WriteLine($"Finished");
    }
    
    
}

