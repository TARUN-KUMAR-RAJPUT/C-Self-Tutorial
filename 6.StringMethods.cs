using System;

public class Test
{
	public static void Main()
	{
	    string s = "Uchiha", t = "";
	    int n = s.Length;
	    
	    Console.WriteLine(n);
	    
	    t = s;
	    Console.WriteLine(t.ToUpper());
	    
	    t = s;
	    Console.WriteLine(t.ToLower());
	    
	    Console.WriteLine(s + t);
	    
	    string firstName = "Uchiha";
        string lastName = "Itachi";
        string name = $"My full name is: {firstName} {lastName}";
        Console.WriteLine(name);
        
        
        Console.WriteLine(s[0]);
        
        Console.WriteLine(s.IndexOf("e"));
        
	}
}
