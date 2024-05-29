using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        namespace RecipeMaker
    {
        public class Ingredient
        {
     public string Name { get; set; }
     public double Quantity { get; set; }
     public string Measurement { get; set; }
     public string FoodGroup {  get; set; } 
     public double Calories {  get; set; }  


           

            public Ingredient(string name, double quantity, string measurement, string foodGroup, double calories )
            {
                Name = name;
                Quantity = quantity;
                Measurement = measurement;
                FoodGroup=foodGroup;
                Calories = calories;
            }

        //***********************************************************************************************************************************************
        public override string ToString()
            {
            return $"{Quantity} {Measurement} of {Name} (Food Group: {FoodGroup}, Calories: {Calories})";
        }
    }
        }
    

