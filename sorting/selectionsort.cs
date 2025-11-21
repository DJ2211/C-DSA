using System;
using System.Collections.Generic;

public class Program{
	public static void Main(){
		List<int> unsortedList = new List<int> {99, 44, 6, 2, 1, 63, 87, 283, 4, 0};
			
		List<int> sortedList = selectionSort(unsortedList);
		printList(sortedList);
	}

	public static List<int> selectionSort(List<int> list){
		
		// do something for null or return if list has only one element
	
		int length = list.Count;

		for(int i = 0; i < length; i++){
			int temp = list[i];
			int min = i;
			bool isSwapped = false;
			for(int j = i + 1; j < length; j++){
				if(list[j] < list[min]){
					min = j;
					isSwapped = true;
				}
			}
			if(!isSwapped){
			    return list;
			}
			// swap min with the jth value
			list[i] = list[min];
			list[min] = temp;
			
			Console.WriteLine($"for i : {i} ");
			printList(list);
			Console.WriteLine();
		}	
		
		return list;
	}
	
	
		
	public static void printList(List<int> array){
	    for(int i = 0; i < array.Count; i++){
	        Console.Write($"{array[i]} "); 
	    }
	}
}


	