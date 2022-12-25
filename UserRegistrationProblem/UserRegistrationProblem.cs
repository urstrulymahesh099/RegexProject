using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexProject
{
    internal class UserRegistrationProblem
    {
        public void CheckName()
        {
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();
            string pattern = "[A-Z]{1}[a-z]{3,}";
            Regex regex = new Regex(pattern);
            if(regex.IsMatch(name))
            {
                
                Console.WriteLine(name+ " is Valid Name");
            }
            else
            {
                Console.WriteLine(name + " is Invalid Name");
            }
        }
        public void CheckLastName()
        {
            Console.WriteLine("Enter last name");
            var name = Console.ReadLine();
            string pattern = "[A-Z]{1}[a-z]{3,}";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(name))
            {

                Console.WriteLine(name + " is Valid Name");
            }
            else
            {
                Console.WriteLine(name + " is Invalid Name");
            }
        }
        public void CheckEmail()
        {
            Console.WriteLine("Enter Email ID");
            var email = Console.ReadLine();
            string pattern = "^[0-9A-Za-z]+([.][0-9A-Za-z]+)[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(email))
            {

                Console.WriteLine(email + " is Valid Email ID");
            }
            else
            {
                Console.WriteLine(email + " is Invalid Email ID");
            }
        }
        public void CheckMobileNumber()
        {
            Console.WriteLine("Enter Mobile Number");
            var MobileNumber = Console.ReadLine();
            string pattern = @"^91+[ ][0-9]{10}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(MobileNumber))
            {

                Console.WriteLine(MobileNumber + " is Valid Mobile Number");
            }
            else
            {
                Console.WriteLine(MobileNumber + " is Invalid Mobile Number");
            }
        }
        public void CheckCharacters()
        {
            Console.WriteLine("Enetr Minimum 8 Charecters");          
            var characters = Console.ReadLine();
            string pattern = @"^[a-z]{8,}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(characters))
            {

                Console.WriteLine(characters + " is Valid characters");
            }
            else
            {
                Console.WriteLine(characters + " is Invalid characters");
            }
        }
        public void CheckUpperCaseCharacters()
        {
            Console.WriteLine("Enetr UpperCase Charecters");
            var uppercasecharacters = Console.ReadLine();
            string pattern = @"^[A-Z]{1}[a-z]{8,}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(uppercasecharacters))
            {

                Console.WriteLine(uppercasecharacters + " is Valid uppercase characters");
            }
            else
            {
                Console.WriteLine(uppercasecharacters + " is Invalid uppercase characters");
            }
        }
        public void CheckNumericNumber()
        {
            Console.WriteLine("Enetr Numeric Number");
            var numericNumber = Console.ReadLine();
            string pattern = @"^[A-Z]{1}[a-z]{8,}[0-9]{1}$";

            Regex regex = new Regex(pattern);
            if (regex.IsMatch(numericNumber))
            {

                Console.WriteLine(numericNumber + " is Valid Numeric Number");
            }
            else
            {
                Console.WriteLine(numericNumber + " is valid Numeric Number");
            }
        }
    }
}
