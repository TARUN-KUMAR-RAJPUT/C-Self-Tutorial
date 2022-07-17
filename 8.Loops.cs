using System;

public class Test
{
	public static void Main()
	{
	    int x = 5;
	    
	    while(x > 0) {
	        Console.WriteLine(x--);
	    }
	    
	    for(int i = 0; i < 5; i++) {
	        
	        if(i == 3) {
	            Console.WriteLine(i);
	            break;
	        }
	    }
	    
	}
}
