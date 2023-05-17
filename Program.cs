using System.Reflection.Metadata.Ecma335;

namespace UserRegistrationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome User Registration Problem");

            Console.Write("Enter First Name: ");
            String firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName= Console.ReadLine();
            if (IsValidFirstName(firstName) && IsValidLastName(lastName))
            {
                Console.WriteLine("First name and Last name is valid.");
            }
            else
            {
                Console.WriteLine("First Name and Last name is Invalid.");
            }
        }
        static bool IsValidFirstName(string firstName)
        {
            if(firstName.Length >=3 && char.IsUpper(firstName[0])) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsValidLastName(string lastName)
        {
            if(lastName.Length >=3 && char.IsUpper(lastName[0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}