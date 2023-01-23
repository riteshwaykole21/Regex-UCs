using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationSystem
{
    public class UserDetails
    {
        public static void FirstName()      
        {
            Console.WriteLine("Enter your FirstName");
            string userInput = Console.ReadLine();
            string regexCondition = "^[A-Z]{1}[a-z]{3,}$";
            Iteration(userInput, regexCondition);
        }
        public static void LastName()      
        {
            Console.WriteLine("Enter your Last Name");
            string userInput = Console.ReadLine();
            string regexCondition = "^[A-Z]{1}[a-z]{3,}$";
            Iteration(userInput, regexCondition);
        }
        public static void Emailid()
        {
            Console.WriteLine("Enter Your Email Id");
            string userInput = Console.ReadLine();
            string regexCondition = "^[a-z0-9]{1,}([._+-]{1}[a-z0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-z]{2,3})";
            Iteration(userInput,regexCondition);
        }
        public static void MobileNumber()
        {
            Console.WriteLine("Enter Your Mobile Number");
            string userInput = Console.ReadLine();
            string regesCondition = "^[9]{1}[1]{1}[ ]{1}[1-9]{1}[0-9]{9}$";
            Iteration(userInput,regesCondition);    
        }
        public static void PassMin8Char()
        {
            Console.WriteLine("Enter your Passwoard");
            string userInput = Console.ReadLine();
            string regexCondition = "^[a-zA-ZO-9]{8,}$";
            Iteration(userInput, regexCondition);
        }
        public static void PassMin8CharAnd1UpperCase()
        {
            Console.WriteLine("Enter Your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "^(?=.*[A-Z]),{1,}[a-zA-ZO-9]{7,}$";
            Iteration(userInput, regexCondition);
        }
        public static void UpperCase1AndNumeric1()
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "^(?=.*[A-Z]).{1,}(?=.*[0-9]).{1}[a-zA-ZO-9]{6,}$";
            Iteration(userInput ,regexCondition);
        }
        public static void SpecialCharacter1()
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-]).{8,}$";
            Iteration(userInput, regexCondition);
        }
        public static void Iteration(string userInput, string regexCondition)
        {
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Validated successfully!\n");
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
            }
        }
    }
}