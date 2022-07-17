using System;
using System.Linq;


public class Vegetable {
    
    // public string color;
    
    // public string Color {a
    //     get { return color; }
    //     set { color = value; }
    // }
    
    
    public string color { get; set; } // Equivalent to above
}


public class Fruit{
    
    
	public static void Main() {
	    
    	Vegetable objV = new Vegetable();
	    objV.color = "green";
	    Console.WriteLine(objV.color);
	}
}
