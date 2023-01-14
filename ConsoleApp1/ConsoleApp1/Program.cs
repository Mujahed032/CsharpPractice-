using System;

namespace ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your string");
            string stringtoreverse=Console.ReadLine();
            string reversed = null;
            reversed = funtiontoreverseastring(stringtoreverse);

        }

        private static string funtiontoreverseastring(string stringtoreverse)
        {
            string reversedx = null ;
            int j = 0;

            for (int i = stringtoreverse.Length - 1; i >= 0; i--)
            {
                reversedx = reversedx + stringtoreverse[i] ;
                j++;
            }
            return reversedx;
        }
    }
}