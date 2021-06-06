using System;

namespace CodeAcademy___Strings
{
    class Program
    {
        static void Main(string[] args)
        {
//TASK1 - CHECK LENGTH OF STRING, CHECK WHETHER STRING CONTAINS VALUE
        // Create password
           string password = "a92301j2add";
        // Get password length
           int passwordLength = password.Length;
           Console.WriteLine(passwordLength);
            // Check if password uses symbol
            int passwordCheck = password.IndexOf("!");
            // Print results
            Console.WriteLine($"The user password is {password}. " +
               $"Its length is {passwordLength} and it " +
               $"receives a {passwordCheck} check.");
//TASK2 - SUBSTRING
            // User Name
            string name = "Farhad Hesam Abbasi";
            // Get first letter
            int charPosition = name.IndexOf("F");
            char firstLetter = name[charPosition];
            Console.WriteLine(charPosition);
            //
            /*The following is a better way of doing it than the exercise, because 
             * it's variable and doesn't depend on you knowing the first letter, 
             * which you won't..
            */
            char FirstChar = name[0];
            Console.WriteLine(FirstChar);
            // Get last name
            int SurnameFix = name.IndexOf("Abbasi");
            string lastName = name.Substring(SurnameFix);
            // Print results
            Console.WriteLine(lastName);
            // Want to work out a way of writing out the surname without knowing what it is,
            // But knowing what position it will be at.
            //
//TASK3 - MANIPULATE STRINGS
            // Script line
            string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";
            // Get camera directions
            int charPosition2 = script.IndexOf("Close");
            int length = "Close on".Length;
            string cameraDirections = script.Substring(charPosition, length);
            // Get scene description
            charPosition2 = script.IndexOf("a portrait");
            string sceneDescription = script.Substring(charPosition2);
            // Make camera directions uppercase
            cameraDirections = cameraDirections.ToUpper();
            // Make scene description lowercase
            sceneDescription = sceneDescription.ToLower();
           // Print results
            Console.WriteLine($"{cameraDirections} {sceneDescription}");

        }
    }
    }
     
