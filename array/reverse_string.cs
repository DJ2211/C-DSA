using System; 

public class Program{
    // initial method from which program is executed
    public static void Main() {
        
        string originalString = "My Name is Jay";
        
        // It will return reversed String of parameter
        // var reversedString = reverseString(originalString);
        var reversedString = reverseStringWithBetterSolution(originalString);
        
        // Console to compare both string
        Console.WriteLine(originalString);
        Console.WriteLine(reversedString);
    }
    
    // this is a brute force approach TC = O(n) and SC = O(n)
    public static string reverseString(string originalString){
        // brute force approach
        // store in string array
        char[] originalCharArray = originalString.ToCharArray();
        
        // to store char in reversed order
        char[] reversedCharArray = new char[originalString.Length];
        
        // storing original string's char in reversed order
        for(int i = originalCharArray.Length - 1, j = 0; i >=0; i--, j++) {
            reversedCharArray[j] = originalCharArray[i];
        }
        
        // to convert from array to string
        string reversedString = new string(reversedCharArray);
        
        return reversedString;
    }
    
    // this is a better solution TC = O(n) and SC = O(1)
    public static string reverseStringWithBetterSolution(string originalString) {
         // store in string array
        char[] originalCharArray = originalString.ToCharArray();
        
        int i = 0, j = originalCharArray.Length - 1;
        
        char swapedElement;
        
        while(i<j) {
            swapedElement = originalCharArray[i];
            originalCharArray[i] = originalCharArray[j];
            originalCharArray[j] = swapedElement;
            i++;
            j--;
        }
        
        string reversedString = new string(originalCharArray);
        return reversedString;
    }
}