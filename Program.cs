using System;

namespace RecipeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe myRecipe = new Recipe();

            myRecipe.CreateRecipe();
            myRecipe.Display();

            myRecipe.ScaleIngredient();
            myRecipe.Display();

            Console.WriteLine("Would you like to reset the recipe and start over? (Yes/No)");
            string resetChoice = Console.ReadLine().ToLower();

            if (resetChoice == "yes")
            {
                myRecipe.Reset();
                Main(args); // Restart the program
            }
            else
            {
                Console.WriteLine("Exiting");
            }
        }
    }
}
