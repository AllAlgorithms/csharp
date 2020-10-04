using System;
					
public class Program
{
	public static bool IsPrime(int num)
	{
		if (num <= 1) return false;
    	if (num == 2) return true;
    	if (num % 2 == 0) return false;
		
		var mid=(int)Math.Floor((Math.Sqrt(num)));
		
		for (int i = 3; i <= mid; i+=2) 
		{
			if((num%i) == 0)
			{
				return false;				
      		}
  		}	
		return true;
	}
}