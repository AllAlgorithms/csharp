using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
   public class Program
    {
        public static string replacing(string keyword)
        {
            char[] trChars = { 'ı', 'ğ', 'İ', 'Ğ', 'ç', 'Ç', 'ş', 'Ş', 'ö', 'Ö', 'ü', 'Ü', ' ' };
            char[] engChars = { 'i', 'g', 'I', 'G', 'c', 'C', 's', 'S', 'o', 'O', 'u', 'U', '-' };
            for (int i = 0; i < trChars.Length; i++)
            {

                keyword = keyword.Replace(trChars[i], engChars[i]);

            }
            return keyword;
        }
        static void Main(string[] args)
        {
            string key = "Merhaba Dünya";
            Console.WriteLine(replacing(key));//Merhaba-Dunya
            Console.ReadKey();
        }
    }
}
