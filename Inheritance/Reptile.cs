using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class
    public class Reptile : Animal
    {

        public bool IsColdBlooded { get; set; }
        public string Name { get; set; }
        public bool HasScales { get; set; }
        public string PreferredHabitat { get; set; }



        public Reptile()
        {

        }

        public Reptile(bool isColdBlooded, string name, bool hasScales, string preferredHabitat, string color, string type, int age, int weight)
        {

            Name = name;
            IsColdBlooded = isColdBlooded;
            PreferredHabitat = preferredHabitat;
            Color = color;
            Type = type;
            Age = age;
            HasScales = hasScales;
            Wieght = weight;

        }

    }        
}
