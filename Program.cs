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

            Console.Write("Enter Mobile Number: ");
            string mobileNum = Console.ReadLine();

            Console.Write("Enter PassWord: ");
            string password= Console.ReadLine();

            if (IsValidFirstName(firstName) && IsValidLastName(lastName) && IsValidEmail(email) && IsValidMobileNumber(mobileNum) && IsValidPassword(password))
            {
                Console.WriteLine("First name, Last name, Email, Mobilenumber and Password is valid.");
            }
            else
            {
                Console.WriteLine("First Name, Last name, Email, MobileNumber and Password is Invalid.");
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
        static bool IsValidMobileNumber(string mobileNum)
        {
            if (mobileNum.Length == 13 && mobileNum[2] == ' ' && IsNumeric(mobileNum.Substring(3)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsNumeric(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsValidPassword(string password)
        {
            if (password.Length >= 8 && ContainsUppercase(password) && ContainsNumeric(password))
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
        static bool ContainsUppercase(string value)
        {
            foreach (char c in value)
            {
                if (char.IsUpper(c))
                {
                    return true;
                }
            }
            return false;
        }
        static bool ContainsNumeric(string value)
        {
            foreach (char c in value)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}