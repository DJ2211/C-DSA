// has pair with sum
// [1, 2, 3, 9] sum = 8
// [1, 2, 4, 4] sum = 8


using System;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        var str = new List<string> {"a", "b", "c", "d", "e"};
        
        // now here we will add the element in the list
        str.Add("f"); // O(1)
        
        // now here we will remove the last element from the list
        str.RemoveAt( str.Count - 1); // O(1)
        
        // now here we will insert the element at our desired index
        str.Insert(2, "alien"); // O(n)
        
        str.Insert(0, "hi"); //O(n)
        
        foreach (var element in str){
            Console.WriteLine(element);
        }
    }
}
