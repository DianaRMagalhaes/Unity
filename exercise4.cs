using System;

namespace Exercise3
{
    internal class Program {
        static void Main(string[] args)
        {
            int firstAltitude = int.Parse(Console.ReadLine());
            int secondAltitude = int.Parse(Console.ReadLine());
            if (firstAltitude >= secondAltitude){
                int distanceAltitude = firstAltitude - secondAltitude;
                Console.WriteLine("The total distance beetween the 2 Altitudes given is " + distanceAltitude);
            }
            else{
                int distanceAltitude = secondAltitude - firstAltitude;
                Console.WriteLine("The total distance beetween the 2 Altitudes given is " + distanceAltitude);
            }
            
        } 
    }
    
}