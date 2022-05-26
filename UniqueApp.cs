using System;
namespace UniqueApp
{
    public class Unique
    {

        public static bool hasAllUniqueCharacters(String str)
        {
            Dictionary<char, int> i = new Dictionary<char, int>();

            foreach (char j in str)
            {
                if (i.ContainsKey(j))
                    return false;
                else
                    i.Add(j, 1);
            }
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