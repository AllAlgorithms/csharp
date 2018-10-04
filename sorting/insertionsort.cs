using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[] { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            var res = insertionSort(vetor);
            foreach(var item in res)
                Console.WriteLine(item);
            Console.ReadKey();
        }

        public static int[] insertionSort(int[] vetor)
        {
            int i, j, atual;
            for (i = 1; i < vetor.Length; i++)
            {
                atual = vetor[i];
                j = i;
                while ((j > 0) && (vetor[j - 1] > atual))
                {
                    vetor[j] = vetor[j - 1];
                    j = j - 1;
                }
                vetor[j] = atual;
            }
            return vetor;
        }
    }
}


