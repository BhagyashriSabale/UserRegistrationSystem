namespace UserRegistrationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome User Registration Problem");

            Console.Write("Enter First Name: ");
            String firstName = Console.ReadLine();
            if (IsValidFirstName(firstName))
            {
                Console.WriteLine("First name is valid.");
            }
            else
            {
                Console.WriteLine("First Name is not valid.");
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
    }
}