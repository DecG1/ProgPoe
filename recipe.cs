using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipeMaker
{
    internal class recipe
    {

        public class Recipe
        {
            // array declaration for steps and ingredients 
            string[] ingredients;
            string[] steps;


            public void RecipeStorage()
            {

                ingredients = new string[0];
                steps = new string[0];  


            }


        //method to create recipe
        public void recipeCreator()
        {

            try
            {

                Console.WriteLine("Please enter Number of ingredients: ");

                string ingNumString = Console.ReadLine();

                int ingNum = int.Parse(ingNumString);

                ingredients=new string[ingNum];
               
                //for loop that prompts user depending on how many ingredients they enter
                for (int i = 1; i <= ingNum; i++)
                {


                    Console.WriteLine($"Ingredient {i} ");

                    Console.WriteLine("Please enter the ingredient name: ");
                    string ingredientName=Console.ReadLine();

                    Console.WriteLine("Please enter the ingredient quantity: ");
                    string ingrediantQuant=Console.ReadLine();

                    Console.WriteLine("Please enter the unit of measurement(Tablespoon...etc): ");
                    string ingredientMeasurement=Console.ReadLine();


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

            //loops depending on number of steps
            for (int i = 1; i <= stepNum; i++)
            {
                Console.WriteLine($"Step {i} ");
                Console.ReadLine();


            }

        }


    }
}
