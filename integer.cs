using System;
//Integer data types lecture code
namespace IntegerDataTypes
{
    internal class Program {
        static void Main(string[] args)
        {
            int totalSecondsPlayed = 100;
            const int SecondsPerMinute = 60;    

            //calculate minutes and seconds played
            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute; 
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;

            //print minutes and seconds played
            Console.WriteLine("Minutes Played: " + minutesPlayed);
            Console.WriteLine("Seconds Played: " + secondsPlayed);

        } 
    }
    
}