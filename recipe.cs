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
            string[] ingrendients;
            string[] steps;
        }

        public void recipeCreator()
        {
            Console.WriteLine("Please enter Number of ingredients: ");


            try
            {
                string ingNumString = Console.ReadLine();

                int ingNum = int.Parse(ingNumString);


for (int i= 0; i < ingNum; i++){
         


            }

            

            }
          
            catch (Exception ex) { 
            
            }


        }
        

    }
}
