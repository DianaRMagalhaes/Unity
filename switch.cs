using System;
//Integer data types lecture code
namespace SwitchStatement
{
    internal class Program {
        static void Main(string[] args)
        {
            Console.Write("Pick up the shiny thing? (1 for yes, 2 for no): ");
            int answer = int.Parse(Console.ReadLine());
            //print appropriate message
            switch (answer){
                case 1:
                    Console.WriteLine("You picked up the shiny thing.");
                    break;
                case 2:
                    Console.WriteLine("You missed the shiny thing.");
                    break;
                default:
                    Console.WriteLine("Invalid Input, Dork!!");
                    break;
            }
        } 
    }
    
}