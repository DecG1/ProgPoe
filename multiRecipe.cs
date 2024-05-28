using System;
using System.Collections.Generic;
using RecipeMaker;
namespace RecipeMaker
{
    public class RecipeBook
    {
        public List<Recipe> Recipes { get; set; }

        public RecipeBook()
        {
            Recipes = new List<Recipe>();

        }

        public void AddRecipe(Recipe recipe)
        {

            Recipes.Add(recipe);

        }

        //**************************************************************************************************************************************

        public void DisplayRecipes()
        {
            for (int i = 0; i < Recipes.Count; i++)
            {
                Console.WriteLine($"\nRecipe {i + 1}:\n");
                Recipes[i].Display();
            }
        }

        public void ScaleRecipe()
        {
            Console.WriteLine("Enter the number of the recipe you want to scale:");
            DisplayRecipes();
            int recipeIndex = int.Parse(Console.ReadLine()) - 1;

            if (recipeIndex >= 0 && recipeIndex < Recipes.Count)
            {
                Recipes[recipeIndex].ScaleIngredient();
            }
            else
            {
                Console.WriteLine("Invalid recipe number.");
            }
        }

        public void ResetRecipe()
        {
            Console.WriteLine("Enter the number of the recipe you want to reset:");

            DisplayRecipes();

            int recipeIndex = int.Parse(Console.ReadLine()) - 1;

            if (recipeIndex >= 0 && recipeIndex < Recipes.Count)
            {
                Recipes[recipeIndex].Reset();
            }
            else
            {
                Console.WriteLine("Invalid recipe number.");
            }
        }
    }
}
