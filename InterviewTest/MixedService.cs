using InterviewTest.Models;
using System;
using System.Linq;

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
            return "Hello World";
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
            //Insertion Sort

            //Loop through each item in the index
            for (int i = 0; i < results.Length; i++) {
                var item = results[i];
                var currentIndex = i;

                //Loop through each item in the indexes after the index we started at
                //Check if the item has a lower value than the index after them
                while (currentIndex > 0 && results[currentIndex - 1].CompareTo(item)>0)
                {
                    //then we shift that item below them up by 1
                    results[currentIndex] = results[currentIndex - 1];
                    currentIndex--;
                }

                results[currentIndex] = item;
            }
            //Inbuilt sort function Version
           // Array.Sort(results);

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
            Person result =  null;
            var foundCount = 0;
            //loop through each person
            for (int i = 0; i < people.Length; i++)
            {
                //Check if person names match in a case insensitive way
                //personName.Equals(name,StringComparison.CurrentCultureIgnoreCase) could also have been used
                string personName = people[i].Name;
                if (personName.ToLower() == name.ToLower()) {
                    //Increment found count and set result as the found object
                    foundCount++;
                    result = people[i];
                }
            }

            //If more than one are found then it must return null
            if (foundCount > 1)
            {
                result = null;
            }

            return result;
        }
    }
}
