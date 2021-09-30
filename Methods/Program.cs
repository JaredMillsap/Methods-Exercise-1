using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code that will be placed inside of method

            MyIntro();
            
        }

        // In order to create a method there must be * Class (

        public static void MyIntro()
        {
            string firstname = "Jared";
            string lastName = "Millsap";
            string Age = "25";


            string myIntro = $" My name is {firstname} {lastName}, I am {Age} years old! ";

            Console.WriteLine(myIntro);
        }







    }
}






































////Scope- 
//string firstname = "Jared";
//string lastName = "Millsap";
//string Age = "25";


//string myIntro = $" My name is {firstname} {lastName}, I am {Age} years old! ";
