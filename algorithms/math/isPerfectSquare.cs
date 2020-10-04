using System;

/// <summary>
/// This is a c# algorithm to check 
/// if a number is a perfect square
/// </summary>
public class Math
{
	public IsPerfectSquare(double num)
	{
        double result = Math.Sqrt(num);
        bool isPerfectSquare = result % 1 == 0;
	}


    ///[Test]
    ///isPerfectSquare returns true for all squares
    ///isPerfectSquare returns false for non perfect squares
}
