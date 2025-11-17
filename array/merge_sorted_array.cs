using System;

public class Program{
    public static void Main(string[] args){
        
        int[] firstIntArray = {0, 3, 7, 11, 17, 22};
        int[] secondIntArray = {2, 5, 7, 72};
        
        // it will merge both sorted array and return it
        int [] mergedArray = mergeSortedArray(firstIntArray, secondIntArray);
        
        // display final merged Array
        for(int i = 0; i < mergedArray.Length; i++) {
            Console.Write(mergedArray[i] + " ");
        }
    }
    
    public static int[] mergeSortedArray(int[] firstIntArray, int[] secondIntArray){
        
        int[] mergedSortedArray = new int[firstIntArray.Length + secondIntArray.Length];
        
        int i =0, j = 0, k = 0;
        
        while( i < firstIntArray.Length && j < secondIntArray.Length){
            if(firstIntArray[i] <= secondIntArray[j]){
                mergedSortedArray[k] = firstIntArray[i];
                i++;
            }else {
                mergedSortedArray[k] = secondIntArray[j];
                j++;
            }
            k++;
        }
        
        if(i == firstIntArray.Length){
            Console.Write("Inside SecondIntArray");
            addRemainingPairs(j, k, secondIntArray, mergedSortedArray);
        }
        
        if(j == secondIntArray.Length -1){
            addRemainingPairs(i, k, firstIntArray, mergedSortedArray);
        }
        
        // while(i < firstIntArray.Length){
        //     mergedSortedArray[k] = firstIntArray[i];
        //     i++;
        //     k++;
        // }
        
        // while(j < secondIntArray.Length){
        //     mergedSortedArray[k] = secondIntArray[j];
        //     j++;
        //     k++;
        // }
        
        
        return mergedSortedArray;
    }
    
    public static int[] addRemainingPairs(int index, int inCompleteArrayIndex,  int [] remainingArray, int [] inCompleteMergeArray){
        for(int i = index; i < remainingArray.Length; i++, inCompleteArrayIndex++){
            inCompleteMergeArray[inCompleteArrayIndex] = remainingArray[i];
        }
        return inCompleteMergeArray;
    } 
    
   
}

// TC = O(n) SC O(n + m).