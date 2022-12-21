using System;
namespace RegexProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to UserRegistrationProblem Problem Statements");
            Console.WriteLine("Select Below Mention Options");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1.Enter Valid Name\n2.Enter Valid Last Name");
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
                    default:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}