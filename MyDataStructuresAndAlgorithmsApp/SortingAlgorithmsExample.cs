namespace MyDataStructuresAndAlgorithmsApp;

public class SortingAlgorithmsExample
{
    public SortingAlgorithmsExample()
    {
        int[] randomArray = [47, 12, 85, 3, 91, 66, 25, 19, 76, 50];
        // randomArray = BubbleSort(randomArray);
        // randomArray = QuickSort(randomArray);
        randomArray = MergeSort(randomArray);
        foreach (var item in randomArray)
        {
            Console.WriteLine($"{item}");
        }
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
        return mergeSortSplit(arr);
    }
    
    private static int[] mergeSortSplit(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return arr;
        }

        var middleIndex = arr.Length / 2;
        var leftArray = arr[..middleIndex];
        var rightArray = arr[middleIndex..];
        return mergeSortMerge(mergeSortSplit(leftArray), mergeSortSplit(rightArray));
    }
    
    private static int[] mergeSortMerge(int[] leftArray, int[] rightArray)
    {
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
}