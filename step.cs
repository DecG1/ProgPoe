using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        namespace RecipeMaker
    {
        public class Step
        {
            public int Order { get; set; }
            public string Description { get; set; }

            public Step(int order, string description)
            {
                Order = order;
                Description = description;
            }

        //***********************************************************************************************************************************************
        public override string ToString()
            {
                return $"{Order}. {Description}";
            }
        }
    }


