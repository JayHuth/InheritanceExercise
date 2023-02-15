using System;
using System.Net.NetworkInformation;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
     /*Create an object of your Bird class
     *  give values to your members using the object of your Bird class
     *  
     * Creatively display the class member values 
     */

            Bird pigeoto = new Bird()
            {

                Name = "Pigeoto",
                Age = 1,
                Type = "Bird",
                Color = "Blue",
                Wieght = 3,
                TypeOfBird = "Blue Bird",
                CanItFly = true,
                Sound = "Tweet Tweet",

            };

            Console.WriteLine($"{pigeoto.Name} is a {pigeoto.Type}, more specifically a {pigeoto.TypeOfBird}. " +
                $"They are a {pigeoto.Age} year old, and they wiegh {pigeoto.Wieght} pounds.");
            Console.WriteLine($"Thier feathers are {pigeoto.Color}, and when they sing they make this sound {pigeoto.Sound}. " +
                $"It is {pigeoto.CanItFly} that pigeoto can fly.");
            Console.WriteLine();

            Reptile lizzy = new Reptile()
            {

                Name = "Lizzy",
                Age = 5,
                Type = "Lizard",
                Color = "Green",
                Wieght = 50,
                HasScales = true,
                PreferredHabitat = "Desert",
                IsColdBlooded = true,
                
            };

            Console.WriteLine($"{lizzy.Name} is a {lizzy.Age} year old {lizzy.Type}, and it is {lizzy.HasScales} that they have scales.");
            Console.WriteLine($"{lizzy.Name}, Weighs a massive {lizzy.Wieght} pounds, and it is {lizzy.IsColdBlooded} that they are cold blooded.");
            Console.WriteLine($"{lizzy.Name}, is {lizzy.Color} and they prefer to live in the {lizzy.PreferredHabitat}");

        }
         
    }
           
    
}
