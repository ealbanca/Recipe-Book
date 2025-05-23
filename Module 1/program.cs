﻿/*Edwin Hared Albancando Robles */
using System;

//This is the main class that that will run the program
class Program
{
    static void Main(string[] args)
    {
        RecipeBook recipebook = new RecipeBook();
        bool quit = false;
        while (!quit)
        {
            //this is the main menu of the program that will show the user the options
            Console.WriteLine("Welcome to your Recipe Book!");
            Console.WriteLine("1. Add a new Recipe");
            Console.WriteLine("2. Save the Recipe");
            Console.WriteLine("3. Load Recipe");
            Console.WriteLine("4. View Recipes");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Please enter a number to select an option:");
            string choice = Console.ReadLine();

            //this is the switch statement that will run the program depending on the user input
            switch (choice)
            {
                case "1":
                    recipebook.AddRecipe();
                    break;
                case "2":
                    recipebook.Save();
                    break;
                case "3":
                    recipebook.Load();
                    break;
                case "4":
                    recipebook.DisplayRecipes();
                    break;
                case "5":
                    quit = true;
                    Console.WriteLine("Thank you for using the Recipe Book!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}