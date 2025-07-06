// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        ArrayExample();
        LinkedListExample();
        StackExample();
        QueueExample();
    }
    
    public static void ArrayExample()
    {
        // Declare and initialize an array of calculator inputs
        string[] inputHistory = { "5 + 3", "10 - 2", "7 * 4", "20 / 5", "3 ^ 2" };
        
        // Print the original input history
        Console.WriteLine($"Original Calculator Input History:");
        foreach (var input in inputHistory)
        {
            Console.WriteLine(input);
        }
        
        // Modifying an entry by index (change "10 - 2" to "10 / 2"), because it is impossible to remove element from 
        // fixed size array
        inputHistory[1] = "10 / 2"; // Updating has O(1) time complexity
        
        // Print the updated input history
        Console.WriteLine($"\n Updated Calculator Input History:");
        foreach (var input in inputHistory)
        {
            Console.WriteLine(input);
        }
    }
    
    public static void LinkedListExample()
    {
        // Declaring and populating a LinkedList
        var linkedList = new LinkedList<string>();
        linkedList.AddLast(new LinkedListNode<string>("Node: 8"));
        linkedList.AddLast(new LinkedListNode<string>("Node: 5"));
        linkedList.AddLast(new LinkedListNode<string>("Node: 28"));
        linkedList.AddLast(new LinkedListNode<string>("Node: 4"));
        linkedList.AddLast(new LinkedListNode<string>("Node: 9"));
        
        // Looping through the linkedList
        foreach (var node in linkedList)
        {
            Console.WriteLine(node);
        }
        
        // Removing a node
        linkedList.Remove("Node: 5");   //Removing has O(1) time complexity
        
        // Looping through updated linkedList
        Console.WriteLine($"\n Looping through updated linkedList:");
        foreach (var node in linkedList)
        {
            Console.WriteLine(node);
        }
    }
    
    public static void StackExample()
    {
        // Declaring and populating a stack
        var undoHistory = new Stack<string>();
        undoHistory.Push("Entered 5 + 3");
        undoHistory.Push("Entered 10 - 2");
        undoHistory.Push("Entered 7 * 4");
        undoHistory.Push("Entered 20 / 5");
        undoHistory.Push("Entered 3 ^ 2");
        
        // Looping through the stack
        Console.WriteLine($"Undo History:");
        foreach (var action in undoHistory)
        {
            Console.WriteLine(action);
        }
        
        // Undoing an action by popping an element in a stack
        Console.WriteLine($"\n Undoing an action: {undoHistory.Pop()}");
        
        Console.WriteLine($"\n Updated Undo History:");
        // Printing the updated stack
        foreach (var action in undoHistory)
        {
            Console.WriteLine(action);
        }
    }
    
    public static void QueueExample()
    {
        // Declaring and populating a queue
        var pendingCalculations = new Queue<string>();
        pendingCalculations.Enqueue("Calculate: 15 + 5");
        pendingCalculations.Enqueue("Calculate: 12 - 3");
        pendingCalculations.Enqueue("Calculate: 9 * 2");
        pendingCalculations.Enqueue("Calculate: 16 / 4");
        pendingCalculations.Enqueue("Calculate: 2 ^ 3");
        
        // Looping through the queue
        foreach (var calculation in pendingCalculations)
        {
            Console.WriteLine(calculation);
        }
        
        // Processing a calculation and dequeuing it
        Console.WriteLine($"\n Processing a calculation: {pendingCalculations.Dequeue()}");
        
        // Printing the updated queue
        Console.WriteLine($"\n Updated queue:");
        foreach (var calculation in pendingCalculations)
        {
            Console.WriteLine(calculation);
        }
    }
}

