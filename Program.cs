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

            Console.Write("Enter Valid Email: ");
            string email = Console.ReadLine();

            if (IsValidFirstName(firstName) && IsValidLastName(lastName) && IsValidEmail(email))
            {
                Console.WriteLine("First name, Last name and Email is valid.");
            }
            else
            {
                Console.WriteLine("First Name, Last name and Email is Invalid.");
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
        static bool IsValidEmail(string email)
        {
            int atIndex = email.IndexOf('@');
            int dotIndex = email.LastIndexOf('.');
            if (atIndex > 0 && dotIndex > atIndex + 1 && dotIndex < email.Length - 1)
            {
                string[] parts = email.Split('@');
                if (parts.Length == 2)
                {
                    string[] domainParts = parts[1].Split('.');
                    if (domainParts.Length >= 2)
                    {
                        foreach (string part in domainParts)
                        {
                            if (part.Length < 2)
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                }
            }
            return false;
        }
    }
}