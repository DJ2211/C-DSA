//	   9
//	 /  \
//	3    12
//     / \    / \
//    2   5  10  16

using System;
using System.Collections.Generic;

public class Node{
	public int Value = null;
	public Node Left = null;
	public Node Right = null;
	
	// constructor
	public Node(int value){
		this.Value = value;
		this.Left = null;
		this.Right = null;
	}
}

public class BinaryTree{
	
	public Node Root = null;

	// constructor
	public BinaryTree(){
		this.Root = null;
	}

	// insert method to insert value in binary tree
	public static void Insert(int value){
		// create a new node
		var newNode = new Node(value);

		if(this.Root == null){
			this.Root = newNode;
		}else {
			currentNode = this.Root;
			while(true){
				if(currentNode < newNode){
					if(currentNode.Left == null){
						currentNode.Left = newNode;
						return;
					}else {
						currentNode = currentNode.Left;
					}
					
				}else {
					if(currentNode.Right == null){
						currentNode.Right = newNode;
						return;
					}else {
						currentNode = currentNode.Right;
					}
				}
			}
		}
	}


	// lookup method
	public static bool Lookup(int value){
		if(this.Root == null){	
		Console.WriteLine("The Binary Search Tree is Empty");
		return false;
		}

		var currentNode = this.Root;
		while(currentNode != null){
			if(value < currentNode){
				currentNode = currentNode.Left;
			}else if(value > currentNode){
				currentNode = currentNode.Right;
			}else if (currentNode == value){
				return true;
			}
		}
		return false;
	}

	// breadth first search
	public static List<int>? BreadthFirstSearch(){

		if(this.Root == null){
			Console.WriteLine("Cannot Perform BreadthFirstSearch due to empty Tree");
			return null;
		}
		var currentNode = this.Root;
		List<int> finalist = new List<int>();
		List<Node> intermediateQueue = new List<Node>();
		intermediateQueue.Add(currentNode);


		while(intermediateQueue.Length > 0){
			currentNode = intermediateQueue.Shift();
			Console.Write($"{currentNode.Value}");
			finalist.Add(currentNode.Value);

			if(currentNode.Left){
				intermediateQueue.Add(currentNode.Left);
			}
			if(currentNode.Right){
				intermediateQueue.Add(currentNode.Right);
			}
		}
		return finallist;
	}
	

	// breadth First Search using Recursion
	public List<int> BreadthFirstSearchUsingRecursion(Queue<Node> intermediateQueue, List<int> finalList){
		if(intermediateQueue.Count == 0){
			return finalist;
		}

		var currentNode = intermediateQueue.Dequeue();
		Console.Write($"{currentNode.Value}");
			finalist.Add(currentNode.Value);

			if(currentNode.Left){
				intermediateQueue.Add(currentNode.Left);
			}
			if(currentNode.Right){
				intermediateQueue.Add(currentNode.Right);
			}
		return this.BreadthFirstSearchUsingRecursion(intermediateQueue, finalList);

	}
public List<int> StartRecursiveBFS()
    {
        if (this.Root == null)
            return new List<int>();

        // 1. Initial Call Fix: Initialize Queue with the Root and an empty List
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(this.Root); 
        
        return BreadthFirstSearchUsingRecursion(queue, new List<int>());
    }
	
}


public class Program{
	public static void Main() {
		var myBinaryTree = new BinaryTree();
		myBinaryTree.Insert(9);
		myBinaryTree.Insert(3);
		myBinaryTree.Insert(12);
		myBinaryTree.Insert(2);
		myBinaryTree.Insert(5);
		myBinaryTree.Insert(12);
		myBinaryTree.Insert(16);
		myBinaryTree.Lookup(9);
		List<int> sortedNodes = myBinaryTree.StartRecursiveBFS();	
	}
}

