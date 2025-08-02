// See https://aka.ms/new-console-template for more information

using MyDataStructuresAndAlgorithmsApp;
using MyDataStructuresAndAlgorithmsApp.Tree;

public class Program
{
    public static void Main(string[] args)
    {
        // new SimpleDataStructuresExample();
        // new SortingAlgorithmsExample();
        
        var newList = new List<TreeNode>()
        {
            new TreeNode(42),
            new TreeNode(17),
            new TreeNode(63),
            new TreeNode(8),
            new TreeNode(95),
            new TreeNode(34),
            new TreeNode(76),
            new TreeNode(21),
            new TreeNode(59),
            new TreeNode(3),
            new TreeNode(88),
            new TreeNode(14),
            new TreeNode(70),
            new TreeNode(27),
            new TreeNode(90),
            new TreeNode(11),
            new TreeNode(68),
            new TreeNode(52),
            new TreeNode(36),
            new TreeNode(7),
        };
        var tree = new Tree<TreeNode>(new TreeNode(50));
        foreach (var treeNode in newList)
        {
            tree.AddNode(treeNode);
        }
        
        Console.WriteLine($"Finished");
    }
    
    
}

