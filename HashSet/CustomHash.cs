using System;
using System.Collections.Generic;

public class Program{
    public static void Main(string[] args){
        var myHash = new HashTable(50);
        myHash.Set("grapes", 1000);
        myHash.Set("apple", 54);
        myHash.Set("apple", 72);
        myHash.Set("samplE", new {message = "this is Hell, And I like it"});
        myHash.Set("SamplE", 12);
        myHash.PrintAll();
        
    }
}

public class HashTable{
    private List<KeyValuePair<string, object>>[] data;
    
    // constructor to initialize a size to data List
    public HashTable(int size){
        this.data = new List<KeyValuePair<string, object>>[size];
    }
    
    // hash function 
    private int Hash(string key){
        int hash = 0;
        for(int i = 0; i < key.Length; i++) {
            hash = (hash + (key[i] * i)) % this.data.Length;
        }
        
        return hash;
    }
    
    // set function to set object into data
    public void Set(string key, object value) {
        
        int address = this.Hash(key);
        // if the address is null then create a data first
        if(this.data[address] == null){
            this.data[address] = new List<KeyValuePair<string, object>>();
        }
        var pair = new KeyValuePair<string, object>(key, value);
        this.data[address].Add(pair);
    }
    
    // get function to get object from data
    public object Get(string key) {
        
        int address = this.Hash(key);
        
        if(this.data[address] == null) {
            return null;
        }
        
        // TO Get data if there are collissions in the HashTable
        var currentBucket = this.data[address];
        
        foreach (var pair in currentBucket) { 
            if(pair.Key == key) { 
                return pair.Value;
            }
        }
        return null;
        
    }
    
    // To Print all the key value pair of the Data Column
    public void PrintAll(){
        if(this.data != null) {
            for(int i = 0; i < this.data.Length; i++) { 
                
                // First It will check if the bucket is not null
                if(this.data[i] != null){
                    
                    // Iterate through entire bucket 
                    Console.Write($"Bucket {i}: ");
                    
                    foreach(var pair in this.data[i]){
                        Console.Write($"[key : {pair.Key} , value : {pair.Value}] ");
                    }
                    Console.WriteLine();
                }
                
            }
            Console.WriteLine("----------------------------------------");
        }
    }
}

// Created a custom hash 
// Lookup O(1)
// Insert O(1) and if collison then O(n)
// Search O(1)
