using System;
using System.Linq;


public class Vegetable {
    public string color = "green";
    public void fun1() {
        Console.WriteLine("fun1 is called ");
    }
}


public class Fruit{
    
    string taste = "sweet";
    
    public void fun() {
        Console.WriteLine("fun is called ");
    }
    
	public static void Main() {
	    
	    Fruit objF = new Fruit();
    	Vegetable objV = new Vegetable();
	    
	    Console.WriteLine(objF.taste);
	    objF.fun();
	    Console.WriteLine(objV.color);
	    objV.fun1();
	}
}
