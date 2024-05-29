//Declan 
//ST10356556
//Group 2

//References List:

//https://code-maze.com/add-values-to-csharp-array/
//https://www.w3schools.com/cs/cs_switch.php
//https://stackoverflow.com/questions/6965337/sort-a-list-alphabetically
//https://www.geeksforgeeks.org/out-parameter-with-examples-in-c-sharp/
//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/





using System;
using System.Data.Common;
using RecipeMaker;

namespace recipeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            RecipeBook recipeBook = new();

            while (true)
            {

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Recipe Maker");
                Console.WriteLine("1. Add a new recipe");
                Console.WriteLine("2. Display all recipes");
                Console.WriteLine("3. Scale a recipe");
                Console.WriteLine("4. Reset a recipe");
                Console.WriteLine("5. Display Specific Recipes");
                Console.WriteLine("6. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine();

                        Recipe addedRecipe= new Recipe();

                        addedRecipe.CreateRecipe(calWarning);

                        recipeBook.AddRecipe(addedRecipe);

                        break;
                    case "2":

                        recipeBook.DisplayRecipes();

                        break;

                    case "3":

                        recipeBook.ScaleRecipe();

                        break;

                    case "4":

                        recipeBook.ResetRecipe();

                        break;

                        case "5":

                            recipeBook.ChooseRecipeDisplay();

                        break;

                    case "6":

                        return;

                    default:

                        Console.WriteLine("Invalid choice, please try again.");

                        break;
                }
            }
        }

        public static void calWarning(string warningMessage) 
        { 

            Console.WriteLine(warningMessage);  

        }
    }
}
