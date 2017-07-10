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

            string mybirthMonth = "September";
            string myFriendBirthMonth = "December";
            string myVehicle = Vehicle(mybirthMonth);
            string myFriendVehicle = Vehicle(myFriendBirthMonth);

            Console.WriteLine("My future vehicle is {0} and Jordan's future vehicle is {1}.", myVehicle, myFriendVehicle);

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
    }
}
