using System;
//Integer data types lecture code
namespace ReadDocumentation
{
    internal class Program {
        static void Main(string[] args)
        {
        int fahrenheit= 0;
        int conv_Celsius= ((fahrenheit-32) / 9 * 5);
        int conv_Fahrenheit= ((conv_Celsius * 9) / 5 + 32);
        Console.WriteLine("The Conversion from Fahrenheint to Celsius is "+ conv_Celsius);
        Console.WriteLine("The conversion from Celsius back to Farhenheint is "+ conv_Fahrenheit);

        } 
    }
    
}