// Factorial

using System;

public class Program{
	public static void Main() {
		int factorial = 5;

		// factorial using iterations
		Console.WriteLine(factorialUsingIterations(factorial));

		// factorial using Recursion
		Console.WriteLine(factorialUsingIterations(6));
	}

	public static int? factorialUsingIterations(int? factorial){
		if(factorial < 0) {
			return null;
		}

		if(factorial == 0 || factorial == 1){
			return 1;
		}

		int factorialAnswer = 1;

		for(int i = 1; i <= factorial; i++){
			factorialAnswer = factorialAnswer * i;
		}

		return factorialAnswer;
	}
	
	public static int? factorialUsingRecursion(int? factorial) {
		if(factorial < 0){
			return null;
		}

		// base case
		if(factorial == 0 || factorial == 1){
			return 1;
		}
		

		//recursive part
		return (factorial * factorialUsingRecursion(factorial - 1));
	}
}

