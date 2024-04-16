using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace recipeMaker
{
    public class recipe
    {

        public class Recipe
        {
            // array declaration for steps and ingredients 
            public string[] ingredients;
            public string[] steps;


            public void RecipeStorage()
            {

                ingredients = new string[0];
                steps = new string[0];


            }


            //method to create recipe
            public void RecipeCreator()
            {



                try
                {

                    Console.WriteLine("Please enter Number of ingredients: ");

                    string ingNumString = Console.ReadLine();

                    int ingNum = int.Parse(ingNumString);

                    ingredients = new string[ingNum];

                    //for loop that prompts user depending on how many ingredients they enter
                    for (int i = 0; i < ingNum; i++)
                    {


                        Console.WriteLine($"Ingredient {i + 1} ");

                        Console.WriteLine("Please enter the ingredient name: ");
                        string ingredientName = Console.ReadLine();

                        Console.WriteLine("Please enter the ingredient quantity: ");
                        string ingrediantQuant = Console.ReadLine();

                        Console.WriteLine("Please enter the unit of measurement(unit of measurement, gram etc...): ");
                        string ingredientMeasurement = Console.ReadLine();



                        ingredients[i] = ingredientName;

                        Console.Clear();



                    }



                }

                catch (Exception ex)
                {

                }


                //prompt user to enter steps
                Console.WriteLine("Enter number of Steps");

                string stepsNum = Console.ReadLine();

                int stepNum = int.Parse(stepsNum);

                steps = new string[stepNum];
                //loops depending on number of steps
                for (int i = 0; i < stepNum; i++)
                {
                    Console.WriteLine($"Step {i + 1} ");
                    steps[i] = Console.ReadLine();


                }

            }

            public static void RecipeDisplay(string[] ingredients, string[] steps)
            {



                Console.WriteLine("The recipe has the following ingredients and steps:\n");

                Console.WriteLine("Ingredients:");
                for (int i = 0; i < ingredients.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.{ingredients[i]}");
                }

                Console.WriteLine("\nSteps:");
                for (int i = 0; i < steps.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {steps[i]}");


                }
            }


            public void ScaleRecipe()
            {

                Console.WriteLine("Would you like to scale the recipe? (Yes/No)");


                string choice = Console.ReadLine();

                if (choice == "Yes")
                {
                    
                    
                    double originalQuant;
                    string originalMeasurement = "";
                    double ingredientQuant = 0;
                     string ingMeasurement="";

                    Console.WriteLine("Please input the quantity you wish to scale");
                    ingredientQuant = int.Parse(Console.ReadLine());

                    originalQuant = ingredientQuant;

                    Console.WriteLine("Please input measurement you wish to scale");
                    ingMeasurement=Console.ReadLine();   

                     originalMeasurement = ingMeasurement;


                    Console.WriteLine("Choose a number and thus its respective scale value");
                    Console.WriteLine("1: Scale by 0.5");
                    Console.WriteLine("2: Scale by 2");
                    Console.WriteLine("3: Scale by 3");

                    string choice2 = Console.ReadLine();

                    double scaleAmount=1;
                    switch (choice2)
                    {

                        case "1" :
                            scaleAmount = 0.5;
                            break;

                        case "2" :
                            scaleAmount = 2;
                            break;

                        case "3" :
                            scaleAmount = 3;
                            break;

                        default:

                            Console.WriteLine("Please enter a correct scale value");
                            break;
                    }

                    ingredientQuant *= scaleAmount;


                    ingMeasurement = $"{scaleAmount}x {ingMeasurement}";



Console.WriteLine($"the Scaled quantity is now : {ingredientQuant} and the new measurement is {ingMeasurement}");




                    Console.WriteLine("Would you like to reset the values to the original values you provided? (Yes/No)");

                    string choice3=Console.ReadLine();  


                    if(choice3 == "Yes")
                    {
                        ingredientQuant = originalQuant;

                        ingMeasurement=originalMeasurement;


                        Console.WriteLine($"The quantities and measurements are now reset to: {ingredientQuant} and {ingMeasurement}");
                    }
                }



            }

        }
    }
}
    



