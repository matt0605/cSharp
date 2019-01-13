using System;
using System.Text;

//Session 3

class EntryPoint
{
    static void Main()
    {
        //Array --somethings that can hold value

        //string iAmArray = "array";

        //Console.WriteLine(iAmArray);
        //Console.WriteLine(iAmArray[3]); //will print a, the third index 0,1,2,3,4
        //                                //Console.WriteLine(iAmArray[5]); //this will throw an error because 5 is outside of the array

        ////create an array of string

        //string[] iAmStringArray = new string[3];    //initiate the array

        //iAmStringArray[0] = "First item";
        //iAmStringArray[2] = "Third item";

        //change the value

        //iAmStringArray[0] = "First";  //can't do this. Cant change a string that already exists



        //string iAmArray = "array";

        //string[] iAmStringArray = { "aaa", "bbb", "ccc", "ddd", "eee" }; //use curly brackets

        //Console.WriteLine(iAmStringArray[3]);

        ////get length of array , how many items inside the array

        //Console.WriteLine(iAmStringArray.Length);
        //Console.WriteLine(iAmArray.Length);


        ////create array for other data types
        ////int[] integerArray = new int[5];
        //int[] integerArray = { 1, 2, 3, 4, 43257 };


        //integerArray[3] = 123;


        //***** Convert any Data Type to a String

        //int someCrazyNumber = 4536334;
        //Console.WriteLine(someCrazyNumber);
        //Console.WriteLine(someCrazyNumber.GetType()); //get data type

        //string theNumberWasStringed = someCrazyNumber.ToString();
        //Console.WriteLine(theNumberWasStringed);
        //Console.WriteLine(theNumberWasStringed.GetType()); //get data type
        //Console.WriteLine(theNumberWasStringed[3]); //should print out 6 from string '4536334'


        //bool theTrue = true;

        //Console.WriteLine(theTrue.ToString()[2]); //print the u in 'true'


        //********************String tricks
        //learn if string contains character, Index of, Last index of, lower/uppercase, to char array, new string

        //string coffeMug = "CoFfee";



        //Console.WriteLine(coffeMug.Contains("o")); //will display true if the string coffe contains o
        //Console.WriteLine(coffeMug.Contains("l")); //false
        //Console.WriteLine(coffeMug.Contains("of")); //true

        //Console.WriteLine(coffeMug.IndexOf("f"));
        //Console.WriteLine(coffeMug.IndexOf("of")); //only gives the index of the first character


        //Console.WriteLine(coffeMug.LastIndexOf('f')); // displays 3 

        //Console.WriteLine(coffeMug.ToLower());
        //Console.WriteLine(coffeMug.ToUpper());

        //char[] coffeCharArray = coffeMug.ToCharArray();

        //Console.WriteLine(coffeMug[2]);
        //Console.WriteLine(coffeCharArray[2]);


        //Console.WriteLine(new string('-', 40)); //will print 40 hyphens or whatever you choose, can place this anywhere in your code

        //string dashes = new string('-', 40);
        //Console.WriteLine(dashes);
        //Console.WriteLine(dashes);
        //Console.WriteLine(dashes);
        //Console.WriteLine(dashes);


        // **********Type  Casting, Converting , Parsing 

        //int number = 5;
        //string word = "number";
        //char x = 'x';
        //float floating = 3.14F;

        ////type casting 
        ////int someInt = floating; //will not work
        //int someInt = (int)floating; //will work

        ////convert
        //string convertedChar = x.ToString();


        ////parse
        //// string wordd = "7";
        //string wordd = null;
        ////number = Convert.ToInt32(wordd); //prints  7
        //number = int.Parse(wordd);  //prints 7
        //                            //The difference between Convert and Parse is that Convert will not give you an error when the string is null

        //// number = (int)char.GetNumericValue(x);

        //Console.WriteLine(number);

        //Generate random number

        //Random rng = new Random();

        //Console.WriteLine(rng.Next());
        //Console.WriteLine(rng.Next(1,15));
        //Console.WriteLine(rng.Next(1,15));
        //Console.WriteLine(rng.Next(1,15));


        //   Homework 2:

        //1. Declare a variable for each of the data types in this section and assign an appropriate value. - Int, Float, Double, Bool, Char, String, Object

        //int intVariable = 1972;
        //Console.WriteLine(intVariable);

        //float floatVariable = 3.14f;
        //Console.WriteLine(floatVariable);

        //double doubleVariable = 3.1111111;  //dont need to add a d
        //Console.WriteLine(doubleVariable);

        //bool booleanVariable = true;
        //Console.WriteLine(booleanVariable);

        //char charVariable = 'c';
        //Console.WriteLine(charVariable);

        //string stringVariable = "mystring";
        //Console.WriteLine(stringVariable);

        //object objectVariable = "12345";
        //Console.WriteLine(objectVariable);




        //2. Read two double numbers from the console.Write a program to successfully compare these numbers with precision of 0.0001.e.g. 3.006 and 3.1 false, 3.00007 and 3.00008 true
        //3.006 and 3.1 false, 3.00007 and 3.00008 true


        //double precisionValue = 0.0001;

        //Read two double numbers from the console
        //Console.Write("firstDouble:  ");
        //double firstDouble = double.Parse(Console.ReadLine());
        //Console.Write("secondDouble:  ");
        //double secondDouble = double.Parse(Console.ReadLine());

        ////Write a program to successfully compare these numbers with precision of 0.0001.e.g. 3.006 and 3.1 false, 3.00007 and 3.00008 true
        //Console.WriteLine(Math.Round(firstDouble, 4) >=  Math.Round(secondDouble, 4));





        //3. Create a character variable and assign it with the character with Unicode 91.

        //char charVar = '\u0091';  //will produce a ?
        // Console.WriteLine(charVar);



        //4.Declare a boolean variable isMyCatAlive and give it an appropriate value, depending on if your cat is or isn't alive.

        //bool isMyCatAlive = false;
        // if (isMyCatAlive)
        //{
        //    Console.WriteLine("The cat is alive");
        //}
        //else
        //{
        //    Console.WriteLine("Cat is not alive");
        //}



        //5. Declare two string variables and assign them with “C#” and “Course”. Declare an object variable and assign it with the concatenation of the first two variables
        //   (mind adding an interval between the words). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

        // Declare two string variables and assign them with “C#” and “Course”.
        //string firstString = "C#";
        //string secondString = " Course";

        ////Declare an object variable and assign it with the concatenation of the first two variables
        //object combineStrings = firstString + " " + secondString;

        ////string thirdString = combineStrings; //does not work without casting
        //string thirdString = (string)combineStrings; //casting

        //Console.WriteLine(thirdString);


        //6. Draw on the console a 5 by 5 rectangle with the symbol "?".

        //string dashes = new string('-', 40);
        //Console.WriteLine(dashes);

        //char recSymbol = '*';
        //string rectTopAndBottom = new string(recSymbol, 5);
        //string recSide = recSymbol + "   " + recSymbol;

        //Console.WriteLine(rectTopAndBottom);
        //for (int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine(recSide);
        //}
        //Console.WriteLine(rectTopAndBottom);


        //7. Read two integer values from the console, save their values in variables, and then exchange the values of these variables.
        //   If the first variable had the value 1 and the second variable had the value 2, after the exchange, 
        //the first variable should get the value 2 and the second variable should get the value 1.

        Console.Write("First Integer: ");
        int firstInt = int.Parse(Console.ReadLine());
        Console.Write("Second Integer: ");
        int secondInt = int.Parse(Console.ReadLine());
        int tempInt;

        Console.WriteLine("Before exchange, the firstInt = {0} secondInt = {1}", firstInt, secondInt);

        bool isEqual = (firstInt == secondInt);        

        if (isEqual)
        {
            Console.WriteLine("The numbers are the same");
        }
        else
        {
            tempInt = firstInt;  
            firstInt = secondInt;
            secondInt = tempInt;
            Console.WriteLine("Ater exchange, the firstInt = {0} secondInt = {1}", firstInt, secondInt);
        }
    }
}

