using System;

public class Test
{
	public static void Main()
	{
	    
	    int x = Convert.ToInt32(Console.ReadLine());
	    int y = Convert.ToInt32(Console.ReadLine());
	    
	    Console.WriteLine(Math.Max(x,y));
	    Console.WriteLine(Math.Min(x,y));
	    
	    x = 64;
	    
	    Console.WriteLine(Math.Sqrt(x));
	}
}
