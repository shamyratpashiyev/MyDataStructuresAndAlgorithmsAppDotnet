namespace MyDataStructuresAndAlgorithmsApp.Graph;

// Undirected Graph by default.
public abstract class Graph
{
    protected readonly Dictionary<int, List<int>> Nodes = new();
    
    public void AddNode(int nodeValue)
    {
        if (!Nodes.ContainsKey(nodeValue))
        {
            Nodes.Add(nodeValue, new());
        }
    }
    
    public void RemoveNode(int targetNode)
    {
        if (!Nodes.ContainsKey(targetNode))
        {
            throw new Exception("Target node doesn't exist");
        }
        
        Nodes.Remove(targetNode);
        
        // Removing edges pointing to the targetNode
        var relatedNodes = Nodes.Where(x => x.Value.Contains(targetNode)).ToList();
        foreach (var relatedNode in relatedNodes)
        {
            relatedNode.Value.Remove(targetNode);
        }
    }
    
    public virtual void AddEdge(int source, int target)
    {
        if (!Nodes.ContainsKey(source) || !Nodes.ContainsKey(target))
        {
            throw new Exception("Source or target node doesn't exist");
        }

        Nodes[source].Add(target);
        Nodes[target].Add(source);
    }
    
    public virtual void RemoveEdge(int source, int target)
    {
        if (!Nodes.ContainsKey(source) || !Nodes.ContainsKey(target))
        {
            throw new Exception("Source or target node doesn't exist");
        }
        
        Nodes[source].Remove(target);
        Nodes[target].Remove(source);
    }
}