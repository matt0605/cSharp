using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class EntryPoint
{

    static void Main()
    {
        ////Difference Between Write/Writeln
        ////console write is for a single role or same role or line
        //Console.Write("I am learning ");
        //Console.Write("C# from ");
        ////Console.Write("Udemy.");
        //Console.Write("Udemy.\n"); //\n provides a new line
        ////or
        //Console.WriteLine(); //gives you next line 

        ////console writeln provides a new line
        //Console.WriteLine("I am learning ");
        //Console.WriteLine("C# from ");
        //Console.WriteLine("Udemy.");

        //formating string
        //string freshJuice = "Lets make fresh juice from Bananas";
        //string strawberry = "strawberry";
        //int five = 5;
        //float fiveFloat = 500.5666f;


        //Console.WriteLine("{0} and {1}", freshJuice, strawberry);
        //Console.WriteLine("{0, 12}", strawberry); //the 12 represents the length of field to hold strawberry
        //Console.WriteLine("{0, 8}", strawberry); //the 8 represents the length of field to hold strawberry
        //Console.WriteLine("{0, 10}", five); //the five will start in the 10th space
        //Console.WriteLine("{0, 10:C}", five); //C stands for currency
        //Console.WriteLine("{0, 10:C1}", five); // add 1 number after the decimal point
        //Console.WriteLine("{0, 10:C1}", five); // add 1 number after the decimal point
        //Console.WriteLine("{0, 10:C0}", five); // add 0 number after the decimal point
        //Console.WriteLine("{0, 10:C3}", fiveFloat); // add 0 number after the decimal point

        //Escaping  Special Character

        //Console.WriteLine("C:\Users\szeon\Documents\text.txt");  //incorrect
        // escape by adding  a backslash, diplay the next character after the backslash
        //Console.WriteLine("C:\\Users\\szeon\\Documents\\text.txt");  //correct

        //add a @ to avoid adding a backslash
        // Console.WriteLine(@"C:\Users\szeon\Documents\text.txt");  //correct

        // reqarding quotation marks, add a backslash infront of the quotation mark
        //Console.WriteLine("Some text that needs \"quotation marks\"!");

        // if you use the @ symbol use double quotation mark
        //escape the quotation marks with quotation mark
        //Console.WriteLine(@"Some text that needs ""quotation marks""!");

        //no escape is needed for single quotaion marks
        // Console.WriteLine(@"Some text that needs 'single quotation marks'!");


        //Read a character from the console

        // Console.Read(); //let us write a character or more on the console

        //Console.WriteLine("How old are you?");
        // int age = Console.Read();
        //Console.WriteLine("I am " + age + "years old");  // this will state 50 years old, from the ACII table if you type 25 

        // you have to use cast typing
        //Console.WriteLine("How old are you?");
        //int age = Console.Read();
        //char theAge = (char)age;
        //or to save  a lot writing 
        //char theAge = (char)Console.Read();  //will return the ascii  50 and continue with type casting  to char

        // Console.WriteLine("I am " + theAge + " years old");  // this will state 50 years old, from the ACII table 


        /**************************/
        //Read a line from the console

        // Console.WriteLine("How old are you?");
        //string age = Console.ReadLine();  //can  use more than 1 charater

        // Console.WriteLine("I am " + age + " years old");

        // // if you want to work with the String you must parse or type cast

        // int theNewAge = int.Parse(age) + 1; ;
        // Console.WriteLine();
        // Console.WriteLine(theNewAge);

        /*****************/
        // Read a pressed key from the Console        

        // ConsoleKeyInfo myKey = Console.ReadKey();

        //Console.WriteLine(myKey.Key);

        //Console.WriteLine("\nYou clicked: " + myKey.Key);
        //Console.WriteLine("\nYou clicked: " + myKey.KeyChar);   //will provide the correct case

        //Console.WriteLine("\nYou clicked: " + myKey.Key);
        //Console.WriteLine("\nThe Modifier is : " +  myKey.Modifiers);

        /*****************/
        //Change the color o the console
        //Console.ForegroundColor = ConsoleColor.Magenta; //changes everything on the following row
        //Console.BackgroundColor = ConsoleColor.DarkRed; //changes everything on the following row
        //Console.Clear();    // clears everythih from the coonsole,change the whole background color

        //Console.WriteLine("something red blue green yellow");
        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.BackgroundColor = ConsoleColor.DarkRed; //changes everything on the following row
        //Console.WriteLine("something red blue green yellow");
        //Console.ForegroundColor = ConsoleColor.White;
        //Console.BackgroundColor = ConsoleColor.DarkYellow; //changes everything on the following row
        //Console.WriteLine("something red blue green yellow");
        //Console.ForegroundColor = ConsoleColor.Blue;
        //Console.BackgroundColor = ConsoleColor.DarkGreen; //changes everything on the following row
        //Console.Write("something red blue green yellow"); //same row
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.BackgroundColor = ConsoleColor.DarkBlue; //changes everything on the following row
        //Console.Write("something red blue green yellow"); //same row

        ////get the default color
        //Console.ForegroundColor = ConsoleColor.White;
        ////or
        //Console.ResetColor();
        //Thread.Sleep(2000);  //use System.Threading
        //Console.Clear(); //clears everything from the console

        /*****************/
        //Change the cursor in the console
        //Console.CursorVisible = false; //makes it invisible
        //Console.WriteLine("text text text text text, abc abc");
        //Thread.Sleep(2000);
        //Console.CursorVisible = true; //makes it visible
        //Console.WriteLine("text text text text text, abc abc");


        //where to start typing
        //Console.SetCursorPosition(5, 5); // 5 rows down and 5 space from margin
        //Console.WriteLine("text text text text text, abc abc");

        //change the title on the console
        //Console.Title = "Console Title Example";  //title of the Console

        //how to position, change size of console

        //Console.WindowHeight = 20;  //change the height
        //Console.WindowWidth = 50;  //change the width
        //or
        //Console.SetWindowSize(50, 20); //width or height change at the same time
        //Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight, );
        //change the rows and columns
        //Console.BufferHeight = 200; //also removes scroll bar
        //Console.BufferWidth = 500;
        //or
        //Console.SetBufferSize(500, 200); //width and height
        //Console.WindowLeft = 10; // move the scroller x time to right 
        //Console.WindowTop = 5;  //move the scroller x time from the top
        // or
        //Console.SetWindowPosition(10, 5); // left and top, //will get error if there are no scroller
        //Console.WriteLine("text text text text text, abc abc");
        //Console.WriteLine("text text text text text, abc abc");
        //Console.WriteLine("text text text text text, abc abc");
        //Console.WriteLine("text text text text text, abc abc");
        //Console.WriteLine("text text text text text, abc abc");

        //buffer size can't be smaller than the window size

        //max and min size of screen
        //Console.WriteLine(Console.LargestWindowHeight);
        //Console.WriteLine(Console.LargestWindowWidth);
        //Console.SetWindowSize(Console.LargestWindowWidth,Console.LargestWindowHeight);
        // Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

        /**Quiz**/

        //15 character strings and you want 7 extra space on the left
        //string someString = "123456789012345";
        //Console.WriteLine("{0, 22}", someString);

        //escape forbiddin characters
        //By using the \ right before the forbidden character or @ infront of the whole string 

        //BufferSize controls how much we would be able to scroll vertically and horizontally; 
        //WindowSize controls how many rows and columns will be visible from the console at a given time
        //WindowPosition controls how many rows and columns we will be offsetted from the top left corner of the console
        // when we start or program


        /**** Exercise  ******/

        /*1. Create sevearal strings that contain words and sentences. Utilize Write and WriteLine to correctly construct sentences
        from the wors, print them and print the already constructed sentences. Do Not us string concatenation*/


        //string stringA = "This";
        //string stringB = " is";
        //string stringC = " my";
        //string stringD = " sentence.";
        //string sentence = "This is my sentence.";

        //Console.Write(stringA);
        //Console.Write(stringB);
        //Console.Write(stringC);
        //Console.Write(stringD);
        //Console.WriteLine();
        //Console.WriteLine(sentence);



        /*2.Take the string given in the Hints:2) section and correctly escape all characters that need escaping, so that you can output
        it on the console as shown in the screenshot
        input: Console.Writeline("C:\Program Files\"Microsoft Programs"\'VisualStudio'");
         
         */
        //Console.WriteLine("C:\\Program Files\\\"Microsoft Programs\"\\\'VisualStudio\'");






        /*3.  Ask two inputs from the user "Name of the Program: (string) and "Local Drive Letter:" (character),use the information that was input
        to reconstruct your string from the previous exercise*/

        //Console.WriteLine("Name of the Program:");
        //string nameOfProgram = Console.ReadLine();
        //Console.WriteLine("Local Drive Letter:");
        //ConsoleKeyInfo myKey = Console.ReadKey();
        //Console.WriteLine();
        //Console.WriteLine(myKey.KeyChar + ":\\Program Files\\\"Microsoft Programs\"\\\'" + nameOfProgram + "\'");



        /* 4. You are given a set of strings and numbers. Align them in such way that they look like a columns from a table, limit the numbers after
         the decimal point to only 2 numbers and include a currency for the total*/


        //string title = "Protein Intake Week: 1";
        //string pipe = "|";
        //string horLine = "======================";
        //float firstFloat = 80.88557f;
        //float secondFloat = 94.56465f;
        //float thirdFloat = 78.67893f;
        //float fourthFloat = 88.66654f;
        //float fifthFloat = 88.6466f;
        //float sixthFloat = 76.777f;
        //float seventhFloat = 91.85759f;
        //float totalFloat = 55.77853f;

        //Console.WriteLine(pipe + title + pipe);
        //Console.WriteLine(pipe + horLine + pipe);
        //Console.Write(pipe + "{0, 22:C2}", firstFloat);
        //Console.WriteLine(pipe);
        //Console.Write(pipe + "{0, 22:C2}", secondFloat);
        //Console.WriteLine(pipe);
        //Console.Write(pipe + "{0, 22:C2}", thirdFloat);
        //Console.WriteLine(pipe);
        //Console.Write(pipe + "{0, 22:C2}", fourthFloat);
        //Console.WriteLine(pipe);
        //Console.Write(pipe + "{0, 22:C2}", fifthFloat);
        //Console.WriteLine(pipe);
        //Console.Write(pipe + "{0, 22:C2}", sixthFloat);
        //Console.WriteLine(pipe);
        //Console.Write(pipe + "{0, 22:C2}", seventhFloat);
        //Console.WriteLine(pipe);        
        //Console.WriteLine(pipe + horLine + pipe);
        //Console.Write(pipe + "Total" + "{0, 17:C2}", totalFloat);
        //Console.WriteLine(pipe);




        /* 5. Take the example from the previous exercise and colorize it. Add color to the characters and add different backgroung for the borders,
         separations, title, data and total. Optionally try and extract these colors into variables, that will not change the way
         its being output, but it will make it easier to change colors, if you want to , because you will have to change the color only in the
         variable.*/

        //string title = "Protein Intake Week: 1";
        //string pipe = "|";
        //string horLine = "======================";
        //float firstFloat = 80.88557f;
        //float secondFloat = 94.56465f;
        //float thirdFloat = 78.67893f;
        //float fourthFloat = 88.66654f;
        //float fifthFloat = 88.6466f;
        //float sixthFloat = 76.777f;
        //float seventhFloat = 91.85759f;
        //float totalFloat = 55.77853f;

        //ForegroundColor is the text
        //BackgroundColor is the background
        //I created methods ColorfulMessages and ColorfulBackGround
        //to assign variables you can also do the following:
        //CoonsoleColor charColor = ConsoleColor.White then 
        //call it by: Console.ForegroundColor = charColor;


        //ColorfulMessages(ConsoleColor.Blue);
        //ColorfulBackGround(ConsoleColor.Cyan);
        //Console.WriteLine(pipe + title + pipe);
        //Console.WriteLine(pipe + horLine + pipe);
        //ColorfulMessages(ConsoleColor.Green);
        //ColorfulBackGround(ConsoleColor.DarkGray);
        //Console.Write(pipe + "{0, 22:C2}", firstFloat);
        //Console.WriteLine(pipe);
        //Console.Write(pipe + "{0, 22:C2}", secondFloat);
        //Console.WriteLine(pipe);
        //Console.Write(pipe + "{0, 22:C2}", thirdFloat);
        //Console.WriteLine(pipe);
        //Console.Write(pipe + "{0, 22:C2}", fourthFloat);
        //Console.WriteLine(pipe);
        //Console.Write(pipe + "{0, 22:C2}", fifthFloat);
        //Console.WriteLine(pipe);
        //Console.Write(pipe + "{0, 22:C2}", sixthFloat);  
        //Console.WriteLine(pipe);
        //Console.Write(pipe + "{0, 22:C2}", seventhFloat);
        //Console.WriteLine(pipe);
        //ColorfulMessages(ConsoleColor.Blue);
        //Console.WriteLine(pipe + horLine + pipe);
        //ColorfulMessages(ConsoleColor.Green);
        //ColorfulBackGround(ConsoleColor.White);
        //Console.Write(pipe + "Total" + "{0, 17:C2}", totalFloat);
        //Console.WriteLine(pipe);

        //Console.ResetColor();
        //Thread.Sleep(5000);  //use System.Threading
        //Console.Clear(); //clears everything from the console





        /* 6.Make the size of the console variable so that it always wraps around the text that is output on it and no additional free spaces.
         */

        string title = "Protein Intake Week: 1";
        string pipe = "|";
        string horLine = "======================";
        float firstFloat = 80.88557f;
        float secondFloat = 94.56465f;
        float thirdFloat = 78.67893f;
        float fourthFloat = 88.66654f;
        float fifthFloat = 88.6466f;
        float sixthFloat = 76.777f;
        float seventhFloat = 91.85759f;
        float totalFloat = 55.77853f;

        //ForegroundColor is the text
        //BackgroundColor is the background
        //I created methods ColorfulMessages and ColorfulBackGround
        //to assign variables you can also do the following:
        //CoonsoleColor charColor = ConsoleColor.White then
        //call it by: Console.ForegroundColor = charColor;

        //how to position, change size of console

       Console.SetWindowSize(70, 20); //width or height change at the same time
       //Console.SetBufferSize(50, 20); //width and height cannot be less than window size
       //Console.SetWindowPosition(10, 5); // left and top, //will get error if there are no scroller

        ColorfulMessages(ConsoleColor.Blue);
        ColorfulBackGround(ConsoleColor.Cyan);
        Console.WriteLine(pipe + title + pipe);
        Console.WriteLine(pipe + horLine + pipe);
        ColorfulMessages(ConsoleColor.Green);
        ColorfulBackGround(ConsoleColor.DarkGray);
        Console.Write(pipe + "{0, 22:C2}", firstFloat);
        Console.WriteLine(pipe);
        Console.Write(pipe + "{0, 22:C2}", secondFloat);
        Console.WriteLine(pipe);
        Console.Write(pipe + "{0, 22:C2}", thirdFloat);
        Console.WriteLine(pipe);
        Console.Write(pipe + "{0, 22:C2}", fourthFloat);
        Console.WriteLine(pipe);
        Console.Write(pipe + "{0, 22:C2}", fifthFloat);
        Console.WriteLine(pipe);
        Console.Write(pipe + "{0, 22:C2}", sixthFloat);
        Console.WriteLine(pipe);
        Console.Write(pipe + "{0, 22:C2}", seventhFloat);
        Console.WriteLine(pipe);
        ColorfulMessages(ConsoleColor.Blue);
        Console.WriteLine(pipe + horLine + pipe);
        ColorfulMessages(ConsoleColor.Green);
        ColorfulBackGround(ConsoleColor.White);
        Console.Write(pipe + "Total" + "{0, 17:C2}", totalFloat);
        Console.WriteLine(pipe);

        Console.ResetColor();
        Thread.Sleep(5000);  //use System.Threading
        Console.Clear(); //clears everything from the console
    }

    static void ColorfulMessages(ConsoleColor color)
    {
        Console.ForegroundColor = color;
       // Console.ResetColor();
    }

    static void ColorfulBackGround(ConsoleColor color)
    {
        Console.BackgroundColor = color;
        // Console.ResetColor();
    }

}
