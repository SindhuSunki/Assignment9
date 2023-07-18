using System;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Assignment9
{

    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string userName, email, password;

            try
            {
                Console.WriteLine("Enter userName");
                userName = Console.ReadLine();
                Console.WriteLine("Enter password");
                password = Console.ReadLine();
                Console.WriteLine("Enter email");
                email = Console.ReadLine();
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    throw new ValidationException("All fields are required.");
                }
                if (userName.Length < 6)
                {
                    throw new ValidationException("User name must have atleast 6 characters ");
                }
                else if (password.Length < 8)
                {
                    throw new ValidationException("Password must have atleast 8 characters");
                }
                else
                {
                    Console.WriteLine("  Registration Success" );
                    Console.WriteLine($"Given name : {userName}\t & Password is : {password} \t & email is :{email}");
                   
                }

            }
            catch (ValidationException e)
            {
                Console.WriteLine("Validation Error " + e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of the Program");
                Console.ReadKey();
            }
        }
    }
}
