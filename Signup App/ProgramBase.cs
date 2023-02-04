// See https://aka.ms/new-console-template for more information
namespace Signup_App
{
    internal class ProgramBase
    {
        static void Main(string[] args)
        {
            Console.Title = "My App";
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("Please choose one; 1. Signup 2. login: ");
            string signUp = Console.ReadLine();


            if (signUp == Convert.ToString(1))
            {
                Console.WriteLine("Input your First name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Input your Last name:");
                string lastName = Console.ReadLine();

                Console.WriteLine("Input your email address:");
                string email = Console.ReadLine();

                Console.WriteLine("Input your phone number:");
                int phoneNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input your password:");
                string password1 = Console.ReadLine();
                Console.WriteLine("Input your password again:");
                string password2 = Console.ReadLine();
                if (password1 == password2)
                {
                    Console.WriteLine("Correct, and good to continue");
                }
                else
                {
                    Console.WriteLine("Type your Password again");
                }
            }
            else if (signUp == Convert.ToString(2))
            {
                Console.WriteLine("Input your email address:");
                string emailAddress = Console.ReadLine();

                Console.WriteLine("Input your Password:");
                string password3 = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("datascience" +"");
            }
            
                    



        }
    }
}