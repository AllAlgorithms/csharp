using System;
namespace Algorithms
{
    /// <summary>
    /// This is a C# port of the RabinKarp algorithm
    /// described at https://www.geeksforgeeks.org/rabin-karp-algorithm-for-pattern-searching/
    /// This is merely a demonstration of RabinKarp and not an optimised
    /// implementation that should be used in production environments.
    /// </summary>
    public class RabinKarp
    {
        private static readonly int ALPHABET_SIZE = 256;

        public static void Search(string pattern, string text, int prime)
        {
            int M = pattern.Length;
            int N = text.Length;
            int patternHash = 0; 
            int textHash = 0;
            int h = 1;

            for (int i = 0; i < M - 1; i++)
            {
                h = (h * ALPHABET_SIZE) % prime;
            }

            for (int i = 0; i < M; i++)
            {
                patternHash = (ALPHABET_SIZE * patternHash + pattern[i]) % prime;
                textHash = (ALPHABET_SIZE * textHash + text[i]) % prime;
            }

            for (int i = 0; i <= N - M; i++)
            {
                if (patternHash == textHash)
                {
                    int j;
                    for (j = 0; j < M; j++)
                    {
                        if (text[i + j] != pattern[j])
                            break;
                    }
                      
                    if (j == M)
                    {
                        Console.WriteLine($"Pattern found at index {i}");
                    }
                }
                 
                if (i < N - M)
                {
                    textHash = (ALPHABET_SIZE * (textHash - text[i] * h) + text[i + M]) % prime;

                    if (textHash < 0)
                    {
                        textHash = (textHash + prime);
                    }
                }
            }
        }
    }
}
