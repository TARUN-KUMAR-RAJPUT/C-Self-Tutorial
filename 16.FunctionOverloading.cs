using System;
using System.Linq;


public class Vegetable {
    public string color = "green";
    
    public int add(int a, int b) {
        return a + b;
    }
    
    public string add(string a, string b) {
        return a + b;
    }
}


public class Fruit{
    
	public static void Main() {
	    
	    Vegetable objV = new Vegetable();
	    
	    Console.WriteLine(objV.add(2,3));
	   
	    Console.WriteLine(objV.add("Uchiha ","Itachi"));
	   
	}
}
