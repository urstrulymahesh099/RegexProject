using System;
namespace RegexProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to UserRegistrationProblem Problem Statements");
            Console.WriteLine("Select Below Mention Options");
            
            while (true)
            {
                Console.WriteLine(" 1.Enter Valid Name\n2.Enter Valid Last Name\n3.Enter Valid Email ID\n4.Enter Valid Mobile Number\nRule1:\n5.Enter minimum 8 charecters\nRule2:\n6.Enter uppercase character\nRule3:\n7.Enetr Numeric Number");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UserRegistrationProblem name = new UserRegistrationProblem();
                        name.CheckName();
                        break;
                    case 2:
                        UserRegistrationProblem lastname = new UserRegistrationProblem();
                        lastname.CheckLastName();
                        break;
                    case 3:
                        UserRegistrationProblem email = new UserRegistrationProblem();
                        email.CheckEmail();
                        break;
                    case 4:
                        UserRegistrationProblem mobileNumber = new UserRegistrationProblem();
                        mobileNumber.CheckMobileNumber();
                        break;
                    case 5:
                        Console.WriteLine("As a User need to follow pre-defined Password rules.\nRule1:");
                        UserRegistrationProblem characters = new UserRegistrationProblem();
                        characters.CheckCharacters();
                        break;
                    case 6:                     
                        UserRegistrationProblem uppercharacters = new UserRegistrationProblem();
                        uppercharacters.CheckUpperCaseCharacters();
                        break;
                    case 7:
                        UserRegistrationProblem number = new UserRegistrationProblem();
                        number.CheckNumericNumber();
                        break;
                    default:
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}