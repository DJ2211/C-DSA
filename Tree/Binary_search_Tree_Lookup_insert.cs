using System;

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



}

public class Program{
	public static void Main(){
		var binaryTree = new BinarySearchTree();
		binaryTree.Insert(9);
		binaryTree.Insert(25);
		binaryTree.Insert(75);
		binaryTree.Insert(1);
		binaryTree.Insert(43);
		Console.WriteLine($"Node exist? {binaryTree.Lookup(1)}");
		Console.WriteLine($"Node exist? {binaryTree.Lookup(43)}");
		Console.WriteLine($"Node exist? {binaryTree.Lookup(187)}");
	}
	
}

// TC o(n)