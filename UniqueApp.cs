using System;
namespace UniqueApp
{
    public class Unique
    {

        public static bool hasAllUniqueCharacters(String str)
        {

            // If two similar caracters are found return false
            for (int i = 0; i < str.Length; i++)
                for (int j = i + 1; j < str.Length; j++)
                    if (str[i] == str[j])
                        return false;

            // If none similar caracters are found return true
            return true;
        }

        public static void Main()

        {
            while (true)
            {
                Console.WriteLine("Welcome to the Unique charaters cheker\nPlease introduce your characters: ");


                string input = Console.ReadLine();

                if (hasAllUniqueCharacters(input) == true)
                    Console.WriteLine("The String - " + input
                                      + " - has all unique characters");
                else if (hasAllUniqueCharacters(input) == false)
                    Console.WriteLine("The String - " + input
                                      + " - has duplicate characters");

            }
        }
    }
}