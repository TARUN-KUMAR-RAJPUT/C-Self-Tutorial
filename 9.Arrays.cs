using System;
using System.Linq;

public class Test
{
	public static void Main()
	{
	   // int [] arr = new int [4];  for fixed size array
	    
	    int [] arr = {1, 2, 5, 3, 4};
	    int n = arr.Length;
	    
	    for(int i = 0; i < n; i++) {
	        Console.WriteLine(arr[i]);
	    }
	    
	    foreach(int x in arr) {
	        Console.WriteLine(x);
	    }
	    
	    Array.Sort(arr);
	    
	    foreach(int x in arr) {
	        Console.WriteLine(x);
	    }
	    
	    Console.WriteLine(arr.Max());  
	    Console.WriteLine(arr.Min());  
	    Console.WriteLine(arr.Sum());
	    
	}
}
