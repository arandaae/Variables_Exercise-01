using System;
using System.Collections.Generic;


namespace Variables_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Complete all of the TODO's for this exercise
            // - Once finished save, commit, and then push to GitHub!

            // TODO: Declare 3 constansts
            const string firstName = "Armando";
            const int birthYear = 1992;
            const char middleInitial = 'E';


            #region Types
            // string
            // char
            // bool
            // int
            // double
            // decimal
            #endregion

            // TODO: Declare a variable for each of the types above
            // Make sure to use C# naming convention best practices 
            string lastName;
            char grade;
            bool pass;
            int age;
            double inches;
            decimal account;


            // TODO: Initialize each of the variables with a value
            lastName = "Aranda";
            grade = 'A';
            pass = true;
            age = 30;
            inches = 1.1;
            account = 1.123456789M;


            // TODO: Write out each of the variables to the Console
            Console.WriteLine(lastName);
            Console.WriteLine(grade);
            Console.WriteLine(pass);
            Console.WriteLine(age);
            Console.WriteLine(inches);
            Console.WriteLine(account);

        }

    }
}
