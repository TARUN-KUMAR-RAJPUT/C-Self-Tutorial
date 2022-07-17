using System;
using System.Linq;

public class Test{
    
    static void fun() {
        Console.WriteLine("fun is called ");
    }
    
    static int add(int x, int y) {
        return x + y;
    }
    
	public static void Main(){
	    fun();
	    Console.WriteLine(add(5,6));
	}
}
