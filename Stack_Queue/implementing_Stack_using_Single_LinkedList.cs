// Implement a Stack

using System;

// Node for Stack 
public class Node{
	public string Value;
	public Node Next;

	// constructor for Node
	public Node(string value) {
		this.Value = value;
		this.Next = null;
	}
}

// class for stack with its methods

public class Stack{
	public Node Top;
	public Node Bottom;
	public int Length = 0;

	// Constructor to create the Element
	public Stack() {
		this.Top = null;
		this.Bottom = null;
		this.Length = 0;
	}

	// Pop Method for stack
	public Node Pop() {
		// Check for Is Empty first 
		if(IsEmpty()){
		Console.WriteLine("Stack is Empty. Cannot POP");
		return null;
		}

		Node poppedElement = this.Top;
		
		// If Only One Element 
		if(this.Length == 1)
		this.Bottom = null;

		

		// If stack has more then one Element
		this.Top = this.Top.Next;
		this.Length--;

		return poppedElement;

		
	}

	// push Method for stack

	public void Push(string value) {

		// Otherwise
		var element = new Node(value);

		if(this.Length == 0){
			this.Top = element;
			this.Bottom = element;
		}
		else {
		element.Next = this.Top;
		this.Top = element;
		
		}
		this.Length++;
		
	}

	// peek Method for stack

	public Node Peek() {
		if(IsEmpty()){
		Console.WriteLine("Stack is Empty. Cannot Peek");
		return null;
		}
	
		return this.Top;
	}

	// IsEmpty Check for stack	
	public bool IsEmpty(){
		return this.Length == 0;
	}
}

public class Program{
	public static void Main(){
		var stack = new Stack();
		stack.Push("Google");
		stack.Push("Cloudflare");
		Console.WriteLine($"Top is : {stack.Peek().Value}");
		stack.Pop();
		Console.WriteLine($"New Top is : {stack.Peek().Value}");
	}
}

// TC POP O(1)
// TC PUSH O(1)
// TC PEEK O(1)