using System;
using System.Collections.Generic;


public class Program{
	public static void Main(){
	List<int> unsortedList = new List<int> {99, 44, 6, 2, 1, 63, 87, 283, 4, 0};
	
	List<int> sortedList = mergeSort(unsortedList);
	printList(sortedList);
	}	


	// 99, 44, 6, 2, 1, 63, 87, 283, 4, 0

	// this function has overall tc of o(logn) and merge function has o(n) so when we combine both then for every logn its doing n operations, so n*logn 
	public static List<int> mergeSort(List<int> unsortedList){
		
		// base case for recursion
		if(unsortedList.Count <= 1){
			return unsortedList;
		}

		int middle = unsortedList.Count / 2;

		List<int> leftList = unsortedList.GetRange(0, middle);
		
		List<int> rightList = unsortedList.GetRange(middle, unsortedList.Count - middle);
		Console.Write("left ");
		printList(leftList);
		Console.WriteLine();
		Console.Write("right ");
		printList(rightList);
		Console.WriteLine();
		List<int> array1 = mergeSort(leftList);
		List<int> array2 = mergeSort(rightList);

		return merge(array1, array2);
	}

	public static List<int> merge(List<int> leftList, List<int> rightList){
		List<int> sortedList = new List<int> (leftList.Count + rightList.Count);
		
		int i = 0;
		int j = 0;

		while(i < leftList.Count && j < rightList.Count){
			if(leftList[i] < rightList[j]){
				sortedList.Add(leftList[i]);
				i++;
			}else {
				sortedList.Add(rightList[j]);
				j++;
			}
		}

		while(i < leftList.Count){
			sortedList.Add(leftList[i]);
			i++;
		}

		while(j < rightList.Count){
			sortedList.Add(rightList[j]);
			j++;
		}
		
		return sortedList;
	}

	public static void printList(List<int> list){
		for(int i = 0; i < list.Count; i++){
			Console.Write($"{list[i]} ");
		}
	}
}