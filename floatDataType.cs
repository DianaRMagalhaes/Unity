using System;
//Integer data types lecture code
namespace IntegerDataTypes
{
    internal class Program {
        static void Main(string[] args)
        {
            int score = 1360;
            int totalSecondsPlayed = 10000;  

            //calculate minutes and seconds played
            float pointsPerSecond = (float)score / totalSecondsPlayed;
            //print minutes and seconds played
            Console.WriteLine("Points per Second: " + pointsPerSecond);

        } 
    }
    
}