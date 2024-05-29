using System;
using System.Collections.Generic;
using RecipeMaker;
namespace RecipeMaker;
using System.Linq;

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

        var alphaRecipes=Recipes.OrderBy(r=>r.Name).ToList();   

        foreach (var Recipes in alphaRecipes)
        {
            
            Recipes.Display();
        }
    }

    //**************************************************************************************************************************************
    public void ChooseRecipeDisplay()
    {
        if (Recipes.Count == 0)
        {
            Console.WriteLine("There are no recipes to display");

            return;

        }
        Console.WriteLine("Saved Recipes: ");
        Console.WriteLine();

        for (int i = 0; i < Recipes.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{Recipes[i].Name}");


        }
        Console.Write("Enter the number of the recipe you want to display: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= Recipes.Count)
        {
            Recipes[index - 1].Display();
        }

        else

        {
            Console.WriteLine("Invalid selection. Please try again.");
        }
    }

    //**************************************************************************************************************************************


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

    //**************************************************************************************************************************************

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

    //**************************************************************************************************************************************



}
