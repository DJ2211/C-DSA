public class Graph {
	public int numberOfNodes;
	public List<int> adjacentList;

	// Constructor
	public Graph(){
		this.numberOfNodes = 0;
		this.adjacentList = new List<int>();
	}

	// addVertex Method to add all the vertexes
	public Vertex(int node){
		this.adjacentList[node] = [];
		this.numberOfNodes++;
	}

	// addEdge  Method to add the edges
	public addEdge(int node1, int node2){
		this.adjacentList[node1].Add(node2);
		this.adjacentList[node2].Add(node1);
	}
}

public class Program{
	public static void Main(){
	var graph = new Graph();
	graph.Vertex(1);
	graph.Vertex(2);
	graph.Vertex(3);
	graph.Vertex(4);
	graph.addEdge(1, 2);
	graph.addEdge(1, 3);
	graph.addEdge(1, 4);
	}
}