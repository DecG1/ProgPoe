//Declan 
//ST10356556
//Group 2

//References List:

//https://code-maze.com/add-values-to-csharp-array/
//https://www.w3schools.com/cs/cs_switch.php




using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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


                //try catch block to handle any exceptions
                try
                {
                    //prompting user to enter ingredients
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

                        Console.WriteLine("Please enter the ingredient quantity(Grams): ");
                        string ingrediantQuant = Console.ReadLine();

                        Console.WriteLine("Please enter the unit of measurement(unit of measurement(Teaspoon etc...): ");
                        string ingredientMeasurement = Console.ReadLine();



                        ingredients[i] = ingredientName;

                        Console.Clear();



                    }



                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error occured");
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


            //method to display the entered recipe
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

            //method to scale the recipe
            public void ScaleRecipe()
            {

                Console.WriteLine("Would you like to scale the recipe? (Yes/No)");


                string choice = Console.ReadLine();

                if (choice == "Yes")
                {


                    double originalQuant;
                    string originalMeasurement = "";
                    double ingredientQuant = 0;
                    string ingMeasurement = "";

                    Console.WriteLine("Please input the quantity you wish to scale");
                    ingredientQuant = int.Parse(Console.ReadLine());

                    originalQuant = ingredientQuant;

                    Console.WriteLine("Please input measurement you wish to scale");
                    ingMeasurement = Console.ReadLine();

                    originalMeasurement = ingMeasurement;


                    Console.WriteLine("Choose a number and thus its respective scale value");
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

                            Console.WriteLine("Please enter a correct scale value");
                            break;
                    }

                    for (int i = 0; i < ingredients.Length; i++)
                    {
                        Console.WriteLine($"Enter quantity for ingredient {ingredients[i]}:");
                        double ingredientQuantity = double.Parse(Console.ReadLine());

                        Console.WriteLine($"Enter measurement for ingredient {ingredients[i]}:");
                        string ingredientMeasurement = Console.ReadLine();


                        double scaledQuantity = ingredientQuantity * scaleAmount;
                        string scaledMeasurement = $"{scaleAmount}x {ingredientMeasurement}";

                        Console.WriteLine($"The scaled quantity for ingredient {ingredients[i]} is now: {scaledQuantity} and the new measurement is {scaledMeasurement}");

                        //sets the new quantity according to chosen scale
                        ingredientQuantity *= scaleAmount;


                        ingredientMeasurement = $"{scaleAmount}x {ingMeasurement}";




                        Console.WriteLine($"the Scaled quantity is now : {ingredientQuantity} and the new measurement is {ingredientMeasurement}");




                        Console.WriteLine("Would you like to reset the values to the original values you provided? (Yes/No)");

                        string choice3 = Console.ReadLine();

                        //resets the values to the original one inputted by the user
                        if (choice3 == "Yes")
                        {
                            ingredientQuant = originalQuant;

                            ingMeasurement = originalMeasurement;


                            Console.WriteLine($"The quantities and measurements are now reset to: {ingredientQuant} and {ingMeasurement}");
                        }
                    }

                }

            }
            //reset method to allow the user to clear all entered data and start a new recipe
            public void RecipeReset()
            {
                Console.WriteLine("Do you want to reset the recipe and start over? (Yes/No)");

                string choice4 = Console.ReadLine();

                if (choice4 == "Yes")
                {
                    //clears the array
                    ingredients = new string[0];
                    steps = new string[0];

                    //calls to redo the recipe making system
                    RecipeCreator();
                    RecipeDisplay(ingredients,steps);
                    ScaleRecipe();
                   
                }
                else if (choice4 == "No")
                {
                    //exits the process if selected
                    Console.WriteLine("Exiting");
                    
                }
         
            }
        }
        }
    }

    



