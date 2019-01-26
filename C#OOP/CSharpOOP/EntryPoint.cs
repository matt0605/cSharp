using Characters.Warriors;  //folder
using System;





 public class EntryPoint
    {
        static void Main()
        {
        Warrior theGoodGuy = new Warrior(190, 80, "Sean");
        //theGoodGuy.Height = 190;
        //theGoodGuy.Weight = 80;
        //theGoodGuy.Name = "Sean";

        Warrior theBadGuy = new Warrior(195, 85, "Satan");
        //theBadGuy.Height = 195;
        //theBadGuy.Weight = 85;
        //theBadGuy.Name = "Satan";

        Console.WriteLine(theGoodGuy.Height);
        Console.WriteLine(theBadGuy.Height);

        try
        {
            theGoodGuy.Age = 25;
            theBadGuy.Age = 15;
        }
        catch(ArgumentOutOfRangeException ex)
        {

            Console.WriteLine(ex.Message);

        }

        Console.WriteLine(theGoodGuy.Age);
        Console.WriteLine(theBadGuy.Age);

        theGoodGuy.Greetings(theBadGuy);
        theBadGuy.Greetings(theGoodGuy);

    }
    }

