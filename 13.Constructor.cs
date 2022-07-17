using System;
using System.Linq;


public class Vegetable {
    public string color;
    public Vegetable(){
        color = "green";
    }
}


public class Fruit{
    
    string taste;
    
    Fruit() {
        taste = "sweet";
    }
    
	public static void Main() {
	    
	    Fruit objF = new Fruit();
    	Vegetable objV = new Vegetable();
	    
	    Console.WriteLine(objF.taste);
	    Console.WriteLine(objV.color);
	}
}
