using System;

class ReverseString
{
   static string ReverseString(string inputString){
      char[] charArray = inputString.ToCharArray();
      Array.Reverse( charArray );
      return new string( charArray );
   }
}

static void Main(string[] args){
   Console.WriteLine("Test ReverseString:");
   Console.WriteLine("Reverse of war is" + ReverseString(war));
   Console.WriteLine("Reverse of bat is" + ReverseString(bat));
}