using System;

namespace Characters.Warriors  //same as the folder name
{



    public class Warrior
    {
        private int height;
        private int weight;  //internal uses
        private int age;
        private string name;

        public int Height  //properties
        {

             get
            {
                return height;
            }


            set
            {
                height = value;
            }



        } 
        public int Weight { get; set; }
        public int Age
        {
            get
            {

                return age;
            }
            set
            {
                if (value >= 18 && value <= 45)
                {

                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The age for, {name} must be between 18 and 45.");
                    
                }
               

            }
        }
        public string Name
        {
            get
            {

                return name;

            }

            set
            {

                name = value;

            }
        }

        //constructor
        public Warrior(int height, int weight, string name)
        {
            Height = height;
            Weight = weight;
            Name = name;

        }


        public void Greetings(Warrior warrior)  //use an object as an argument
        {
            Console.WriteLine($@"Greetings,  {Name}!");  //$ use variables ex: name directly inside string
        }


    }

}