using System;
using System.Collections.Generic;

public class Program{
	public static void Main(){
	List<int> unsortedList = new List<int> {99, 44, 6, 2, 1, 63, 87, 283, 4, 0};
	
	List<int> sortedList = insertionSort(unsortedList);
	printList(sortedList);
	}	


	// 99, 44, 6, 2, 1, 63, 87, 283, 4, 0
	public static List<int> insertionSort(List<int> list){

		if(list.Count == 1){
			return list;
		}

		int length = list.Count;
		for(int i = 1; i < length; i++){
			int j = i - 1;
			int currentElement = list[i];
			while(j >= 0 && list[j] > currentElement){
				list[j+1] = list[j];
				j--;
			}
			list[j+1] = currentElement;
		}
		return list;
	}

	public static void printList(List<int> list){
		for(int i = 0; i < list.Count; i++){
			Console.Write($"{list[i]} ");
		}
	}
}