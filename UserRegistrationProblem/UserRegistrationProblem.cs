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
            string pattern = @"^[0-9]{10}$";
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
    }
}
