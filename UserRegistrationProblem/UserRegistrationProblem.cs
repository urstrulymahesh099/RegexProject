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
    }
}
