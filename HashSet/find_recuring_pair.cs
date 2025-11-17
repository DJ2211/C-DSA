
//Google Question
//Given an array = [2,5,1,2,3,5,1,2,4]:
//It should return 2

//Given an array = [2,1,1,2,3,5,1,2,4]:
//It should return 1

//Given an array = [2,3,4,5]:
//It should return undefined

using System;
using System.Collections.Generic;

public class Program{
    public static void Main(){
        
        int[] arrayOfElements = { 2,5,5,2 };
        
        // brute Force approach TC O(n^2) SC(1)
        // var value = findRecurringElement(arrayOfElements);
        // Console.Write(value);
        
        var value2 = findRecurringElementThroughHashing(arrayOfElements);
        Console.Write(value2);
    }
    
    // Brute Force
     public static int? findRecurringElement(int[] array) {
        // if array is not defined
        if(array == null || array.Length == 0){
            return null;
        }
        // to find the matching pair if it's available in array.
        for(int gap = 0; gap < array.Length; gap++) {
            for(int  i = 0, j = gap + 1; j < array.Length; j++, i++) { 
                if(array[i] == array[j]) {
                    return array[i];
                }
            
            }
        }
        return null;
    }
    
    
    // Best Solution Hashing TC will be O(n) and SC will be O(n)
    public static int? findRecurringElementThroughHashing(int[] array) { 
         // if array is not defined
        if(array == null || array.Length == 0){
            return null;
        }
        
        var map = new Dictionary<int, int>();
       
        for(int i = 0; i < array.Length; i++) {
            if(map.ContainsKey(array[i])) {
                return array[i];
            }else {
                map.Add(array[i], i);
            }
        }
        
        return null;
    }
    
}