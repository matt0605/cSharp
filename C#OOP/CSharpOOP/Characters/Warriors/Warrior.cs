using System;

namespace Characters.Warriors  //same as the folder name
{



    public class Warrior
    {
        private int height;
        private int weight;  //internal uses
        private string name;

        public int Height { get; set; }  //external uses
        public int Weight { get; set; }
        public string Name { get; set; }

        //constructor
        public Warrior(int height, int weight, string name)
        {
            Height = height;
            Weight = weight;
            Name = name;

        }


        public void Greetings(Warrior warrior)  //use an object as an argument
        {
            Console.WriteLine($@"Greetings,  {warrior.Name}!");  //$ use variables ex: name directly inside string
        }


    }

}