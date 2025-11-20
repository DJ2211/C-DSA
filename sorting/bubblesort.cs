using System;
using System.Collections.Generic;

public class Program{
	public static void Main(){
		List<int> unsortedList = new List<int> {99, 44, 6, 2, 1, 63, 87, 283, 4, 0};
			
		List<int> sortedList = bubbleSort(unsortedList);
		printList(sortedList);
		
	}

	public static List<int> bubbleSort(List<int> unsortedList){
// 		if(unsortedList == null) {
// 			return null;
// 		}

		if(unsortedList.Count == 1){
			return unsortedList;
		}

		int length = unsortedList.Count;
		Console.WriteLine(length);
		// main implementation for bubbleSort
		for(int i = 0; i < length - 1; i++){
		    Console.Write($"For i = {i}: ");
		    Console.WriteLine();
			for(int j = 0; j < length -1- i; j++){
			    Console.Write($"j = {j}: ");
				printList(unsortedList);
				Console.WriteLine();
				if(unsortedList[j] > unsortedList[j+1]){
					var temp = unsortedList[j];
					unsortedList[j] = unsortedList[j+1];
					unsortedList[j+1] = temp;
				}
				
			}
			Console.Write($"j = last: ");
				printList(unsortedList);
				Console.WriteLine();
			Console.WriteLine();
		}
		
		
		
		return unsortedList;
	}
	
	public static void printList(List<int> array){
	    for(int i = 0; i < array.Count; i++){
	        Console.Write($"{array[i]} "); 
	    }
	}
}
// check out put for more understanding TC O(n^2) SC O(1)


// for i = 0 it was original length - 1 times i.e 10  - 1 = 9
			// 44, 99,  6, 2, 1, 63, 87, 283, 4, 0
			// 44, 6, 99, 2, 1, 63, 87, 283, 4, 0
			// 44, 6, 2, 99 , 1, 63, 87, 283, 4, 0
			// 44, 6, 2, 1, 99, 63, 87, 283, 4, 0
			// 44, 6, 2, 1, 63, 99, 87, 283, 4, 0
			// 44, 6, 2, 1, 63, 87, 99, 283, 4, 0
			// 44, 6, 2, 1, 63, 87, 99, 283, 4, 0
			// 44, 6, 2, 1, 63, 87, 99, 4, 283, 0
			// 44, 6, 2, 1, 63, 87, 99, 4, 0, 283


			// for i = 1 now its length - 2 times i.e 8
			// 6, 44, 2, 1, 63, 87, 99, 4, 0, 283	
			// 6, 2, 44, 1, 63, 87, 99, 4, 0, 283
			// 6, 2, 1, 44, 63, 87, 99, 4, 0, 283
			// 6, 2, 1, 44, 63, 87, 99, 4, 0, 283
			// 6, 2, 44, 1, 63, 87, 99, 4, 0, 283
			// 6, 2, 44, 1, 63, 87, 99, 4, 0, 283	
			// 6, 2, 44, 1, 63, 87, 4, 99, 0, 283
			// 6, 2, 44, 1, 63, 87, 4, 0, 99, 283

			// for i = 2 now 7 times
			// 2, 6, 44, 1, 63, 87, 4, 0, 99, 283
			// 2, 6, 44, 1, 63, 87, 4, 0, 99, 283
			// 2, 6, 1, 44, 63, 87, 4, 0, 99, 283
			// 2, 6, 1, 44, 63, 87, 4, 0, 99, 283
			// 2, 6, 1, 44, 63, 87, 4, 0, 99, 283
			// 2, 6, 1, 44, 63, 4, 87, 0, 99, 283
			// 2, 6, 1, 44, 63, 4, 0, 87, 99, 283	