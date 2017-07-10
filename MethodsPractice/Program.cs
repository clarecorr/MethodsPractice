using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //Methods are a tool for us to create reusable pieces of code
            //Methods are a way of us collecting a series of instructions and then calling them when we need them
            //Methods are always part of a class. Methods are always children of classes
            //This meand that a method will never be created inside another method or member of the class 
            //However methods are frequently called withing another method or class

            //int answer = Add(5, 7);
            //Console.WriteLine(answer);

            //RobotWarning("Will Robinson");
            //Useless();

            //string mybirthMonth = "September";
            //string myFriendBirthMonth = "December";
            //string myVehicle = Vehicle(mybirthMonth);
            //string myFriendVehicle = Vehicle(myFriendBirthMonth);

            //Console.WriteLine("My future vehicle is {0} and Jordan's future vehicle is {1}.", myVehicle, myFriendVehicle);

            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("What is your favorite food?");
            //string faveFood = Console.ReadLine();
            //FavoriteFood(name, faveFood);


            //Console.WriteLine("How old are you?");
            //int age = int.Parse(Console.ReadLine());
            //RetirementCalculator(age);

            //double hoursWorked = 42.3d;
            //double hourlyWage = 12.50d;

            //Console.WriteLine("Your monthly wage is " + WageCalculator(hoursWorked, hourlyWage));


            //Console.WriteLine("How many total projects do you need to complete?");
            //int totalProjects = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many projects have you completed?");
            //int projectsCompleted = int.Parse(Console.ReadLine());
            //double percentCompleted = Math.Round(Percentage(projectsCompleted, totalProjects),2);
            //Console.WriteLine("You have completed {0}% of the total projects.", percentCompleted);

            int heightOfRectA = 10;
            int widthOfRectA = 12;
            double areaOfRectA = AreaOfRect(heightOfRectA, widthOfRectA);
            Console.WriteLine(areaOfRectA);

            

        }

        //Method Header
        //Access Modifier - Return Type - Method Name (in Pascal Case (first letter of each word is cap)) (sometimes with parameters)
        //Static keyword means we don't have to worry about objects
        public static int Add(int firstNumber, int secondNumber)
        {
            //Method Body
            //A complete method - header and body - is called a method declaration

            int sum = firstNumber + secondNumber;

            return sum;
            //The return keyword takes whatever balue is determined by usting this method and sends it back to where I call my method
        }
        //If you have a method that does not have a return value, you can use keyword void
        //When we have a void return type, we don't need to use the keyword return

        public static void RobotWarning(string name)
        {
            Console.WriteLine("Danger, " + name + "!!");
        }

        public static void Useless()
        {
            Console.WriteLine("Blah blah blah");
        }

        public static string Vehicle(string birthMonth)
        {
            string vehicleFortune;
            if (birthMonth.ToUpper() == "SEPTEMBER" || birthMonth.ToUpper() == "OCTOBER")
            {
                vehicleFortune = "Hoverboard";

            }
            else
            {
                vehicleFortune = "SUV";
            }
            return vehicleFortune;
        }

        //Create a method called FavoriteFood
        //It should take two string parameters. One representing a name and the other representing a favorite food
        //The return type should be void
        //The method should concatenate

        public static void FavoriteFood(string name, string favoriteFood)
        {
            Console.WriteLine(name + "'s favorite food is " + favoriteFood);
        }

        //Create a method called RetirementCalculator
        //it should take an int as a parameter representing the user's age
        //The method should calculate how many more years until the user retires using 65 as the age of retirement
        //The return type should be void
        //Once it calculates the user's retirement age it shouold print "The user will retire in x years"

        public static void RetirementCalculator(int userAge)
        {
            int yearsUntilRetirement = 65 - userAge;
            Console.WriteLine("The user will retire in {0} years", yearsUntilRetirement);
        }

        public static double WageCalculator(double hoursWorkedWeekly, double hourlyWage)
        {
            double monthlyWage = (hoursWorkedWeekly * hourlyWage * 52) / 12;
            return monthlyWage;
        }
    

        //create two methods of your choosing. At least one of the methods should have a non-void return type
        //both of the methods should take at least one parameter
        //remember when naming your method it should represent what your method does
        //you method should only aim to accomplish one thing

        public static double Percentage(double part, double whole)
        {
            double percentage = (part / whole) * 100;
            return percentage;

        }

        public static double AreaOfRect(double height, double width)
        {
            double area = height * width;
            return area;
        }
   


    }
}
