﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration using Regex.\n");
            while (true)
            {
                Console.WriteLine("Please select any one from below :\n" +
                "Press 1 : To Register your First Name.\n" +
                "Press 2: To Register your Last Name  \n" +
                "Press 3 :To Enter your Email Id \n" +
                "Press 4 :To enter your Mobile Number \n" +
                "Press 5: To Set Your Passwoard (minimum 8 Character ).\n" +
                "Press 6: To set Password Having 8 Minimum character and atkeast 1 upper case in it .\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UserDetails.FirstName();
                        break;
                    case 2:
                        UserDetails.LastName();
                        break;
                    case 3:
                        UserDetails.Emailid();
                        break;
                    case 4:
                        UserDetails.MobileNumber();
                        break;
                    case 5:
                        UserDetails.PassMin8Char();
                        break;
                    case 6:
                        UserDetails.PassMin8CharAnd1UpperCase();
                        break;
                    default:
                        Console.WriteLine("Invalid option selected ,Please try again !");
                        break;
                }
            }
        }
    }
}
