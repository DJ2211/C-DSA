using System;
using System.Collections.Generic;

public class Node {
	public int Value;
	public Node Left;
	public Node Right;

	public Node(int value) {
		this.Value = value;
		this.Left = null;
		this.Right = null;
	}
}

public class BinarySearchTree {
	public Node root;

	public BinarySearchTree() {
		this.root = null;
	}

	// Insert Method
	public void Insert(int value){
		var newNode = new Node(value);
		
		// add condition 
		if(this.root == null) {
			this.root = newNode;
		}else {
			var currentNode = this.root;
			while(true){
				if(value < currentNode.Value){
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
	
	
		public bool Lookup(int value){
		if(this.root == null){
			return false;
		}
		var currentNode = this.root;
		while(currentNode != null){
			if(value < currentNode.Value){
				currentNode = currentNode.Left;
			}else if(value > currentNode.Value){
				currentNode = currentNode.Right;
			}else if(value == currentNode.Value){
				return true;
			}
		}	
		return false;	
	}

    public  List<int> BreadthFirstSearch(){

		if(this.root == null){
			Console.WriteLine("Cannot Perform BreadthFirstSearch due to empty Tree");
			return null;
		}
		var currentNode = this.root;
		List<int> finalist = new List<int>();
		Queue<Node> intermediateQueue = new Queue<Node>();
		intermediateQueue.Enqueue(currentNode);


		while(intermediateQueue.Count > 0){
			currentNode = intermediateQueue.Dequeue();
			Console.Write($"{currentNode.Value} ");
			finalist.Add(currentNode.Value);

			if(currentNode.Left != null){
				intermediateQueue.Enqueue(currentNode.Left);
			}
			if(currentNode.Right != null){
				intermediateQueue.Enqueue(currentNode.Right);
			}
		}
		return finalist;
	}




}

public class Program{
	public static void Main(){
		var binaryTree = new BinarySearchTree();
		binaryTree.Insert(9);
		binaryTree.Insert(3);
		binaryTree.Insert(12);
		binaryTree.Insert(2);
		binaryTree.Insert(5);
		binaryTree.Insert(10);
		binaryTree.Insert(16);
		Console.WriteLine($"Node exist? {binaryTree.Lookup(1)}");
		Console.WriteLine($"Node exist? {binaryTree.Lookup(43)}");
		Console.WriteLine($"Node exist? {binaryTree.Lookup(187)}");
        binaryTree.BreadthFirstSearch();
	}
	
}


//	          9
//	        /  \
//	       3    12
//        / \    / \
//       2   5  10  16
// TC o(n) SC o(n)