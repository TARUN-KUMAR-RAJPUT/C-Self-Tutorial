using System;
using System.Linq;


//When sealed keyword is used, than No class can be drived from this class.

// sealed class EatFood {
//     public int calory = 300;
//     public void giveValue() {
//         Console.WriteLine("Food value ");
//     }
// }

class EatFood {
    public int calory = 300;
    public void giveValue() {
        Console.WriteLine("Food value ");
    }
}

class Vegetable : EatFood{
    
    public string color = "green";
}


public class Fruit{
    
    
	public static void Main() {
	    
    	Vegetable objV = new Vegetable();
	    objV.giveValue();
	    Console.WriteLine("Food which are " + objV.color + " has calories :");
	    Console.WriteLine(objV.calory);
	}
}
