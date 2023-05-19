using System;
//Integer data types lecture code
namespace IfStatement
{
    internal class Program {
        static void Main(string[] args)
        {
            Console.Write("Pick up the shiny thing? (1 for yes, 2 for no): ");
            int answer = int.Parse(Console.ReadLine());
            //print appropriate message
            if (answer == 1){
                Console.WriteLine("You have the shiny thing!!");
            }
            else if(answer == 2){
                Console.WriteLine("You do not have the shiny thing.");
            }
            else {
                Console.WriteLine("You have not chosen a valid option.");
            }
        } 
    }
    
}