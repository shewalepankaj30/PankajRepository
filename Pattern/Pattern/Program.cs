using System;

namespace patternCode
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Please enter you Number of rows : " );
            int rows = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine( "num of rows : "+rows);

            for (int i = 1; i <= rows; i++) 
            { 
                for (int sp =0 ; sp <=rows-i; sp++)
                {
                    Console.Write(" ");
                    
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= rows-1; i++)
            {
                for (int sp = 0; sp <= i; sp++)
                {
                    Console.Write(" ");

                }
                for (int j = 0; j < rows-i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}