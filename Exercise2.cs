using System;

namespace Exercise2
{
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************");
            Console.WriteLine("MENU:");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Load Game");
            Console.WriteLine("3. Options");
            Console.WriteLine("4. Quit");
            Console.WriteLine("*************************");
            Console.WriteLine("Enter choice: ");
            int answer = int.Parse(Console.ReadLine());
            //print appropriate message
            if (answer == 1){
                Console.WriteLine("Loading Game...");
            }
            else if(answer == 2){
                Console.WriteLine("Loading Game...");
            }
            else if (answer==3){
                Console.WriteLine("Choose from menu options");

            }
            else if (answer==4 ){
                Console.WriteLine("Goodbye");
            }
            else {
                Console.WriteLine("You have not chosen a valid option.");
            }
        } 
    }
    
}