using InterviewTest.Models;

namespace InterviewTest
{
    public class MixedService
    {
        /// <summary>
        /// Return the string "Hello World"
        /// </summary>
        /// <returns>Hello World</returns>
        public string HelloWorld()
        {
            return string.Empty;
        }

        /// <summary>
        /// For a string array, return a new string array with all of the strings in a alphabetical order
        /// </summary>
        public string[] GetAlphabeticalArray(string[] stringArray)
        {
            string[] results = new string[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                results[i] = stringArray[i];
            }

            return results;
        }

        /// <summary>
        /// Searches a list of people and returns one matching the name
        /// If more than one are found then it must return null
        /// If no one is found then return null
        /// The name match must be case-insensitive
        /// </summary>
        public Person FindPersonByName(string name, Person[] people)
        {
            return null;
        }
    }
}
