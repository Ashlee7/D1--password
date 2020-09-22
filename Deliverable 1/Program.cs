using System;
using System.Linq;

namespace Deliverable_1
{ //Write password checker method - must contain min 7 char and max 12 char,
  // 1 lower case, 1 upper case, and 1 special char !
    class Program
    {
        public static void Main(string[] args)
        { 
       
            Console.WriteLine("Enter a password containing a minimum of 7 characters, and a
                max 12 characters, an explaination point, 1 lower, and one upper case letter.");
            string password = Console.ReadLine();

            //Make boolean so we can use in if statements later on for validation 
            bool containsAtLeastOneUppercase = password.Any(char.IsUpper);
            bool containsAtLeastOneLowercase = password.Any(char.IsLower);
            bool containsAtLeastOneSpecialChar = password.Any(ch => !Char.IsLetterOrDigit(ch));
            bool containsAtLeastOneDigit = password.Any(char.IsDigit);


            if (password.Length < 7 || password.Length > 12)
            { Console.Write("Error - Password Length Incorrect.");
            }
             if (!password.Any(char.IsUpper))
            { Console.Write("Error - Uppercase Letter Needed.");
            }

             if (!password.Any(char.IsLower))
            {
                Console.WriteLine("Error- Lowercase Letter Needed.");
            }              
                        
            }

        }
    }
