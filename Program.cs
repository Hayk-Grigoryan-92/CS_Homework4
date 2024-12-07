using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////         Exercise 3.1     //////////////////////////////////////
            //Ex:1 Write a program that prompts the user to enter a number and checks if it is positive, negative, or zero.
            /*
            int num = int.Parse(Console.ReadLine());
           
            if(num > 0)
            {
                Console.WriteLine("Positive");
            }else if(num < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
            */

            //Ex: 2 Create a program that takes an integer input from the user and prints whether it is even or odd
            //using if-else statements.
            /*
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
            */

            //Ex: 3. Write a program that takes three integer inputs and determines which one is the largest.

            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());

            //if (num1 > num2 && num1>num3)
            //{
            //    Console.WriteLine("Num1");
            //}else if (num2 > num1 && num2 > num3)
            //{
            //    Console.WriteLine("Num2");
            //}else if (num3 > num1 && num3 > num2)
            //{
            //    Console.WriteLine("Num3");
            //}
            //else
            //{
            //    Console.WriteLine("Numbers is equal");
            //}

            //Ex: 4. Create a program that takes the age of
            //a person and classifies them into different age groups (child, teenager, adult, senior).
            /*
            int num = int.Parse(Console.ReadLine());

            if(num>0 && num < 10)
            {
                Console.WriteLine("You are child");
            }
            if(num >= 10 && num < 20)
            {
                Console.WriteLine("You are teenager");
            }
            if (num >= 20 && num < 50)
            {
                Console.WriteLine("You are adult");
            }
            if(num >= 50 && num < 80)
            {
                Console.WriteLine("You are senior");
            }
            */

            //Ex:5. Write a program that generates a random number between 1 and 10 and asks the user to guess it.
            //Indicate whether the guess is too high, too low, or correct.
            /*
            Random rnd = new Random();
            int newRnd = rnd.Next(1, 10);

            int userNumber = int.Parse(Console.ReadLine());  

            if(userNumber < newRnd)
            {
                Console.WriteLine("your number too low");
            }
            else if (userNumber > newRnd)
            {
                Console.WriteLine("your number too high");
            }
            else
            {
                Console.WriteLine("You win");
            }
            */

            //Ex: 6. Create a program that simulates rolling two dice and prints their values and the total.
            /*
            Random rnd1 = new Random();
            int dice1 = rnd1.Next(1, 7);
            Console.WriteLine(dice1);

            Random rnd2 = new Random();
            int dice2 = rnd2.Next(1, 7);
            Console.WriteLine(dice2);

            Console.WriteLine(dice1 + dice2);
            */

            //Ex: 7. Write a program that takes a number (1-7) and prints the corresponding day of the week.
            /*
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            */

            //Ex 8. Create a program that asks the user for a number and checks if it is divisible by both 5 and 3.
            /*
            int num = int.Parse(Console.ReadLine());

            if (num % 5 == 0 && num % 3 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            */

            ////////////////////////////         Exercise 4     //////////////////////////////////////

            //Ex: 2. Use string interpolation to format a string with variables.
            /*
            int num1 = 25;
            int num2 = 10;

            Console.WriteLine($"{num1} is greter than {num2}");
            */

            //Ex: 3 Compare two strings using the == operator.
            /*
            string x = "Bob";
            string y = "John";

            Console.WriteLine(x == y);
            */

            //Ex: 7. Check if a year is a leap year using if-else conditions.
            /*
            int year = int.Parse(Console.ReadLine());

            if(year % 400 == 0){
                Console.WriteLine("Year is a leap");
            }else if(year % 4 == 0 && year % 100 == 1)
            {
                Console.WriteLine("Year is a leap");
            }
            else
            {
                Console.WriteLine("Yaer is not leap");
            }
            */

            //Ex: 8. Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
            /*
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());

            Console.WriteLine(input1 * input2 * input3);
            */

            //Ex: 9. Write a C# program to check the sum of the two given integers. Print true if one of the integers
            //is 20 or if their sum is 20
            /*
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            if (input1 == 20 || input2 == 20 || input1 + input2 == 20)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            */

            //EX: 19. Write a program that asks the user to enter their age. Then, check if the age is between
            //18 and 65 (inclusive) using the && operator. Print "You are eligible" if the age meets this condition;
            //otherwise, print "You are not eligible".
            /*
            int age = int.Parse(Console.ReadLine());

            if (age >= 18 && age <= 65)
            {
                Console.WriteLine("You are eligible");
            }
            else
            {
                Console.WriteLine("You are not eligible");
            }
            */

            //Ex: 10. Create a simple login system where the user enters a username and a password. Check if both the
            //username and password match predefined values using the && operator. Print "Login successful" if both match;
            //otherwise, print "Invalid credentials".
            /*
            string login = Console.ReadLine();
            string password = Console.ReadLine();

            string expectedLogin = "Bob";
            string expectedPassword = "Bob123456+";

            if (login == expectedLogin && password == expectedPassword)
            {
                Console.WriteLine("Login succsesfull");
            }
            else
            {
                Console.WriteLine("Invalid credentials");
            }
            */

            //Ex: 11. Prompt the user to enter three side lengths of a triangle. Use the && operator to check
            //if these lengths can form a valid triangle (sum of any two sides is greater than the third side).
            //Print "Valid triangle" if the condition is met; otherwise, print "Invalid triangle".
            /*
            int side1 = int.Parse(Console.ReadLine());
            int side2 = int.Parse(Console.ReadLine());
            int side3 = int.Parse(Console.ReadLine());

            if (side1 + side2 > side3 || side1 + side3 > side2 || side2 + side3 > side1)
            {
                Console.WriteLine("Valid triangle");
            }
            else
            {
                Console.WriteLine("Invalid triangle");
            }
            */

            //EX: 12. Request the user to input their gender as "male" or "female". Use the || operator to check if the
            //input matches either "male" or "female". Print "Valid gender" if the input is correct; otherwise, print
            //"Invalid gender".
            /*
            string gender1 = "Male";
            string gender2 = "Female";

            string userGender = Console.ReadLine();

            if (userGender == gender1 || userGender == gender2)
            {
                Console.WriteLine("Valid genser");
            }
            else
            {
                Console.WriteLine("Invalid gender");
            }
            */

            //EX: 13. Create a program that simulates a credit card validation process. Ask the user to enter a
            //credit card number.(keep it in string type) Use the || operator to check if the card number has either
            //16 digits (Visa/Mastercard) or 15 digits (American Express). Print "Valid card number" if true; otherwise,
            //print "Invalid card number".
            /*
            string userCardNumber = Console.ReadLine();

            if(userCardNumber.Length == 16 || userCardNumber.Length == 15)
            {
                Console.WriteLine("Valid card number");
            }
            else
            {
                Console.WriteLine("Invalid card number");
            }
            */

            //Ex:  Write a C# Sharp program that prints the multiplication table of a number as input.
            /*
            int num = int.Parse(Console.ReadLine());

            int el = 0;

            while (el <= 50)
            {
                Console.WriteLine(el * num);
                el++;
            }
            */

            // Ex: 15. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
            /*
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine((num1 + num2 + num3 + num4) / 2);
            */

            //EX: 16. Write a C# program to check a pair of integers and print true if one is negative and one is positive.
            /*
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 >= 0 && num2 < 0 || num2 >= 0 && num1 < 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            */

            //Ex: 17. Write a program in C# Sharp to accept a grade and declare the equivalent description :(use Switch case)
            /*
            string grade = Console.ReadLine();

            switch (grade)
            {
                case "E":
                    Console.WriteLine("Excellent");
                    break;
                case "V":
                    Console.WriteLine("Very Good");
                    break;
                case "G":
                    Console.WriteLine("Good");
                    break;
                case "A":
                    Console.WriteLine("Average");
                    break;
                case "F":
                    Console.WriteLine("Fail");
                    break;
                    default:
                    Console.WriteLine("You enter wrong grade");
                    break;
            }
            */

            //////////////////////////// Ex: 4,5,6, 18 krknvum ein


            {

            }

            {

            }
        }
    }
}
