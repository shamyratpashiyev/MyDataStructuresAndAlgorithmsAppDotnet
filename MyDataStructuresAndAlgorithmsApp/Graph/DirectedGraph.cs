namespace MyDataStructuresAndAlgorithmsApp.Graph;

public class DirectedGraph : Graph
{
    public override void AddEdge(int source, int target)
    {
        if (!Nodes.ContainsKey(source) || !Nodes.ContainsKey(target))
        {
            throw new Exception("Source or target node doesn't exist");
        }
        
        Nodes[source].Add(target);
    }
    
    public override void RemoveEdge(int source, int target)
    {
        if (!Nodes.ContainsKey(source) || !Nodes.ContainsKey(target))
        {
            throw new Exception("Source or target node doesn't exist");
        }
        
        Nodes[source].Remove(target);
    }
}