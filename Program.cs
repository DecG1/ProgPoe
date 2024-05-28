using System;
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
                Console.WriteLine("Recipe Maker");
                Console.WriteLine("1. Add a new recipe");
                Console.WriteLine("2. Display all recipes");
                Console.WriteLine("3. Scale a recipe");
                Console.WriteLine("4. Reset a recipe");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Recipe addedRecipe= new Recipe();
                        addedRecipe.CreateRecipe();
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
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}
