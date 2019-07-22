using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session11Methods
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter a first and last name");
            string nameOne = Console.ReadLine();  //get information from the console
            string nameLast = Console.ReadLine();
            Console.WriteLine("The following is from the console");
            PrintNames(nameOne, nameLast);  //print from the console             
            PrintNames(); //call the methods
            Console.WriteLine(); //this is a void method
            Console.WriteLine("something");
            PrintNames("Matthew", "Zeon");  //overload method

            //Console.WriteLine("Enter 2 numbers");
            //int numOne = int.Parse(Console.ReadLine());
            //int numTwo = int.Parse(Console.ReadLine());
            ////CompareNumbers(numOne, numTwo); 

            //// Console.WriteLine(MultiplyTwoNumbers(numOne, numTwo));
            ////or
            //int multi = 0;
            //multi = (MultiplyTwoNumbers(numOne, numTwo));
            //Console.WriteLine(multi);







        }

        //Methods should create 1 single thing


        static void PrintNames()    //methods starts with Capital letters
        {
            Console.WriteLine("My first name is Stafford");
            Console.WriteLine("My last name is Zeon");
            Console.WriteLine("I am learning C#");
        }

        //Datatype of the methods:
        //void -- does not return anything


        static void PrintNames(string firstName, string lastName)    //methods starts with Capital letters
        {
            Console.WriteLine("My first name is {0}", firstName);  //{0} are placeholders
            Console.WriteLine("My last name is  {0}", lastName);
            Console.WriteLine("I am learning C#");
        }

        static void CompareNumbers(int n1, int n2)
        {
            if (n1 > n2)
            {
                Console.WriteLine("The number {0} is bigger than the number {1})", n1, n2);
            }
            else if (n1 < n2)
            {
                Console.WriteLine("The number {0} is smaller than the number {1})", n1, n2);
            }

            else
            {
                Console.WriteLine("The number {0} is equal to the number {1})", n1, n2);

            }

        }

        static int MultiplyTwoNumbers(int firstNum, int secondNum)
        {
           // int multiplication = firstNum * secondNum;

           // return multiplication;
            //or
            return firstNum * secondNum;

        }


       
      

    }
}
