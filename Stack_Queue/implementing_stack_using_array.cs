// ik ik why i am implementing stack using array. Am i crazy ? NOooooo


// Implement a Stack

// ik ik why i am implementing stack using array. Am i crazy ? NOooooo


// Implement a Stack

using System;
using System.Collections.Generic;


// class for stack with its methods
public class Stack{
	public List<string> array;

    public int Length => array.Count;

	// Constructor to create the Element
	public Stack() {
		this.array = new List<string>();
	}

	// Pop Method for stack
	public string Pop() {
        if(this.array.Count == 0){
            Console.WriteLine("Array is empty");
            return null;
        }
        var lastIndex = this.array.Count - 1;

        var lastValue = this.array[lastIndex];
		
        this.array.RemoveAt(lastIndex);
        return lastValue;
	}

	// push Method for stack

	public void Push(string value) {
		this.array.Add(value);
	}

	// peek Method for stack
	public string Peek() {
        if(this.array.Count == 0) {
            Console.WriteLine("Array is empty");
            return null;
        }
		return this.array[this.array.Count - 1];
	}

}

public class Program{
	public static void Main(){
		var stack = new Stack();
		stack.Push("Google");
		stack.Push("Cloudflare");
		Console.WriteLine($"Top is : {stack.Peek()}");
		stack.Pop();
		Console.WriteLine($"New Top is : {stack.Peek()}");
	}
}

// TC POP O(1)
// TC PUSH O(1)
// TC PEEK O(1)