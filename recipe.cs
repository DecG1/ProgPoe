using System;
using System.Collections.Generic;

namespace RecipeMaker
{
    public class Recipe
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<Step> Steps { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<Step>();
        }

        public void AddIngredient(string name, double quantity, string measurement)
        {
            Ingredients.Add(new Ingredient(name, quantity, measurement));
        }

        public void AddStep(int order, string description)
        {
            Steps.Add(new Step(order, description));
        }

        public void Display()
        {
            Console.WriteLine("The recipe has the following ingredients and steps:\n");

            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine(ingredient);
            }

            Console.WriteLine("\nSteps:");
            foreach (var step in Steps)
            {
                Console.WriteLine(step);
            }
        }

        //***********************************************************************************************************************************************
        public void ScaleIngredient()
        {
            Console.WriteLine("Would you like to scale the recipe? (Yes/No)");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "yes")
            {
                Console.WriteLine("Choose the ingredient you wish to scale by entering the ingredient name:");
                for (int i = 0; i < Ingredients.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {Ingredients[i].Name}");
                }

                string ingredientName = Console.ReadLine();
                var ingredient = Ingredients.Find(ing => ing.Name.Equals(ingredientName, StringComparison.OrdinalIgnoreCase));

                if (ingredient == null)
                {
                    Console.WriteLine("Ingredient not found.");
                    return;
                }

                Console.WriteLine("Choose a number and thus its respective scale value:");
                Console.WriteLine("1: Scale by 0.5");
                Console.WriteLine("2: Scale by 2");
                Console.WriteLine("3: Scale by 3");

                string choice2 = Console.ReadLine();
                double scaleAmount = 1;

                //switch to choose the scale amount
                switch (choice2)
                {
                    case "1":
                        scaleAmount = 0.5;
                        break;
                    case "2":
                        scaleAmount = 2;
                        break;
                    case "3":
                        scaleAmount = 3;
                        break;
                    default:
                        Console.WriteLine("Please enter a correct scale value.");
                        return;
                }

                ingredient.Quantity *= scaleAmount;
                Console.WriteLine($"The scaled quantity for ingredient {ingredient.Name} is now: {ingredient.Quantity} {ingredient.Measurement}");
            }
        }

        public void Reset()
        {
            Ingredients.Clear();
            Steps.Clear();
        }

        //***********************************************************************************************************************************************
        public void CreateRecipe()
        {
            try
            {
                // Prompting user to enter ingredients
                Console.WriteLine("Please enter Number of ingredients: ");
                int ingNum = int.Parse(Console.ReadLine());

                for (int i = 0; i < ingNum; i++)
                {
                    Console.WriteLine($"Ingredient {i + 1} ");
                    Console.Write("Please enter the ingredient name: ");
                    string ingredientName = Console.ReadLine();
                    Console.Write("Please enter the ingredient quantity: ");
                    double ingredientQuant = double.Parse(Console.ReadLine());
                    Console.Write("Please enter the unit of measurement: ");
                    string ingredientMeasurement = Console.ReadLine();

                    AddIngredient(ingredientName, ingredientQuant, ingredientMeasurement);
                    Console.Clear();
                }

                // Prompt user to enter steps
                Console.WriteLine("Enter number of Steps:");
                int stepNum = int.Parse(Console.ReadLine());

                for (int i = 0; i < stepNum; i++)
                {
                    Console.WriteLine($"Step {i + 1}: ");
                    string stepDescription = Console.ReadLine();
                    AddStep(i + 1, stepDescription);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }
        }
    }
}

//********************************************************************END OF FILE***********************************************************************