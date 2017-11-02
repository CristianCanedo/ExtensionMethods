using System;

namespace ExtensionMethods
{
    public static class Program
    {
        public static int Add(this int number, params int[] toAdd)
        {
            for (int i = 0; i < toAdd.Length; i++)
                number += toAdd[i];
            
            return number;
        }
        
        public static int Multiply(this int number, params int[] toMultiply)
        {
            for (int i = 0; i < toMultiply.Length; i++)
                number *= toMultiply[i];
            
            return number;
        }
        
        public static void Main(string[] args)
        {
            int number = 10;
            int sum = number.Add(5, 5, 5, 5); // 10 + 5 + 5 + 5 + 5
            int product = sum.Multiply(10, 10); // 30 * 10 * 10
            
            Console.WriteLine(sum); // Outputs 30
            Console.WriteLine(product); // Outputs 3000
        }
    }
}
