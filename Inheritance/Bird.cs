using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class

    public class Bird : Animal
    {

        public bool CanItFly { get; set; }

        public string TypeOfBird { get; set; }

        public string Sound { get; set;}
        public string Name { get; set;}

        public Bird()
        {

        }

        public Bird(string name, string sound, string typeOfBird, bool canItFly, int weight, int age, string color, string type)
        {
            Name = name;
            Sound = sound;
            TypeOfBird = typeOfBird;
            CanItFly = canItFly;
            Wieght = weight;
            Age = age;
            Color = color;
            Type= type;
        }


    }
}
