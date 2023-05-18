using System;
//Integer data types lecture code
namespace ReadDocumentation
{
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Which angle you want to calcule? ");
            float input = float.Parse(Console.ReadLine());
            float cosine = MathF.Cos(input * MathF.PI /180);
            float sine = MathF.Sin(input * MathF.PI /180);
            Console.WriteLine("Cosine of the angle is " + cosine);
            Console.WriteLine("Sine of the angle is " + sine);

        } 
    }
    
}