using System;

public class Program{
	public static void Main(){
		int index = 8;
		Console.WriteLine(fibonacciIterative(index));
	}

	// Fibonacci Iterative solution 8 // 0 1 1 2 3 5 8 13
	public static int? fibonacciIterative(int n){
		int value1 = 0;
		int value2 = 1;
		if(n <= 0 ){
			return null;
		}

		if(n < 2){
			return n;
		}



		for(int i = 0; i < n - 1; i++){
			int temp = value1+ value2;
			value1 = value2;
			value2 = temp;
		}

		return temp;
	}

	// Fibonacci Recursive solution 0 1 1 2 3 5 8 13  8
	public static int? fibonacciRecursive(int n){
		
		// base cases for recursion to terminate
	    	if(n < 2) {
			return n;
		}

		return fibonacciRecursive(n - 1) + fibonacciRecursive(n - 2);
	}
}