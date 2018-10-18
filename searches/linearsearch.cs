using System;

public class LS
{
	/// <summary>
	/// Searches through the arrayToSearch to find the key.
	///	Returns the index the key was found at, or -1 if no match was found
	/// </summary>
	static int LinearSearch(int[] arrayToSearch, int key)
	{
		for (var i = 0; i < arrayToSearch.Length; i++)
		{
			if (arrayToSearch[i] == key)
				return i;
		}

		return -1;
	}
	
	public void Main()
	{
		var arrayToSearch = new int[]{1, 2, 3, 4, 5};
		// Should match at index 2
		Console.WriteLine(LinearSearch(arrayToSearch, 3));
		// 7 does not exist in the array to search, will return -1
		Console.WriteLine(LinearSearch(arrayToSearch, 7));
		
		Console.ReadKey();
	}
}