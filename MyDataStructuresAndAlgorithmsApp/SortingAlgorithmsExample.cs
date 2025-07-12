using System.Diagnostics;

namespace MyDataStructuresAndAlgorithmsApp;

public class SortingAlgorithmsExample
{
    public SortingAlgorithmsExample()
    {
        // int[] randomArray = [47, 12, 85, 3, 91, 66, 25, 19, 76, 50];
        var randomArray = GenerateRandomArray(100_000, 1, 100_000);
        
        var timer = new Stopwatch();
        timer.Start();
        var builtInSortResult = randomArray.Order().ToArray();
        timer.Stop();
        Console.WriteLine($"builtInSortResult: {timer.ElapsedMilliseconds} ms, IsSorted: {IsSorted(builtInSortResult)}");
        
        timer.Restart();
        var mergeSortResult = MergeSort(randomArray);
        timer.Stop();
        Console.WriteLine($"mergeSortResult: {timer.ElapsedMilliseconds} ms, IsSorted: {IsSorted(mergeSortResult)}");

        timer.Restart();
        var quickSortResult = QuickSort(randomArray);
        timer.Stop();
        Console.WriteLine($"quickSortResult: {timer.ElapsedMilliseconds} ms, IsSorted: {IsSorted(quickSortResult)}");

        timer.Restart();
        var bubbleSortResult = BubbleSort(randomArray);
        timer.Stop();
        Console.WriteLine($"bubbleSortResult: {timer.ElapsedMilliseconds} ms, IsSorted: {IsSorted(bubbleSortResult)}");
    }
    
    public static int[] BubbleSort(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return arr;
        }

        var isSorted = false;
        
        while (!isSorted)
        {
            isSorted = true;
            // arr.Length - 1 is used in order to avoid OutOfBoundaries exception
            // (it sort of not iterates through the last element because it gets swapped anyway when the previous one is processed)
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    isSorted = false;
                }
            }
        }
        
        return arr;
    }
    
    public static int[] QuickSort(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return arr;
        }
        
        var lessThanArray = new int[0];
        var greaterThanArray = new int[0];
        
        // Selecting and moving pivot to the first position
        int pivotIndex = arr.Length / 2;
        (arr[0], arr[pivotIndex]) = (arr[pivotIndex], arr[0]);
        var pivot = arr[0];

        // Omitting the first value since we moved pivot value there
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] <= pivot)
            {
                lessThanArray = lessThanArray.Append(arr[i]).ToArray();
            }
            else
            {
                greaterThanArray = greaterThanArray.Append(arr[i]).ToArray();
            }
        }
        
        return new int[0].Concat(QuickSort(lessThanArray)).Concat([pivot]).Concat(QuickSort(greaterThanArray)).ToArray();
    }
    
    public static int[] MergeSort(int[] arr)
    {
        // Stops the recursion at the right time
        if (arr.Length <= 1)
        {
            return arr;
        }
        
        // Splitting the array recursively
        var middleIndex = arr.Length / 2;
        var leftArray = MergeSort(arr[..middleIndex]);
        var rightArray = MergeSort(arr[middleIndex..]);
        
        var resultArray = new int[0];
        var leftIndex = 0;
        var rightIndex = 0;
        
        while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
        {
            if (leftArray[leftIndex] < rightArray[rightIndex])
            {
                resultArray = resultArray.Append(leftArray[leftIndex]).ToArray();
                leftIndex++;
            }
            else if (leftArray[leftIndex] > rightArray[rightIndex])
            {
                resultArray = resultArray.Append(rightArray[rightIndex]).ToArray();
                rightIndex++;
            }
            else if (leftArray[leftIndex] == rightArray[rightIndex])
            {
                resultArray = resultArray.Append(leftArray[leftIndex]).Append(rightArray[rightIndex]).ToArray();
                leftIndex++;
                rightIndex++;
            }
        }
        
        // Merging the result with leftover (not processed) elements in both left and right arrays
        return resultArray.Concat(leftArray[leftIndex..]).Concat(rightArray[rightIndex..]).ToArray();
    }
    
    public static bool IsSorted(int[] arr)
    {
        var result = true;
        for (var i = 0; i < arr.Length; i++)
        {
            if (i > 0)
            {
                if (arr[i] < arr[i - 1])
                {
                    result = false;
                }
            }
        }
        return result;
    }
    
    public static int[] GenerateRandomArray(int count, int min, int max)
    {
        Random rand = new Random();
        
        return Enumerable.Range(0, count).Select(_ => rand.Next(min, max)).ToArray();
    }
}