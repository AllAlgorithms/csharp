using System;

class Levenshtein
{
	// The Levenshtein algorithm is a useful algorithm to determine how similar two strings are.
	// The Levenshtein Distance between two strings is essentially defined as the number of
	// changes (alterations, insertions or deletions) that need to be made to change one string
	// to the other. This is useful when implementing fuzzy logic searches such as book titles
	// or online store products where the users are likely to make typing errors which in a
	// direct string comparison would yield no results.
	
    public static int Distance(string source, string target)
    {
        int srcLen = source.Length;
        int trgLen = target.Length;
        int[,] matrix = new int[srcLen + 1, trgLen + 1];

        // Check if either string is empty
        if (srcLen == 0)
        {
            return trgLen;
        }

        if (trgLen == 0)
        {
            return srcLen;
        }

        // Seed matrix
        for (int i = 0; i <= srcLen; matrix[i, 0] = i++)
        {
        }

        for (int j = 0; j <= trgLen; matrix[0, j] = j++)
        {
        }

        // Iterate over source
        for (int i = 1; i <= srcLen; i++)
        {
            // Iterate over target
            for (int j = 1; j <= trgLen; j++)
            {
                // Calculate cost
                int cost = (target[j - 1] == source[i - 1]) ? 0 : 1;

                // Populate matrix
                matrix[i, j] = Math.Min(
                    Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1),
                    matrix[i - 1, j - 1] + cost);
            }
        }
		
        // Return shortest distance
        return matrix[srcLen, trgLen];
    }

    // Test
    static void Main(string[] args)
    {
        Console.WriteLine("Test Levenshtein:");
        Console.WriteLine("Hello World -> Hello world :" + Levenshtein.Distance("Hello World", "Hello world"));
        Console.WriteLine("Gorilla -> Guerilla :" + Levenshtein.Distance("Gorilla", "Guerilla"));
        Console.WriteLine("foo -> bar :" + Levenshtein.Distance("foo", "bar"));
    }
}
