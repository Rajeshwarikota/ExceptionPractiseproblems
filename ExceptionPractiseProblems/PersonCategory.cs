using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractiseProblems
{
    class PersonCategory
    {
        public static void Categories()
        {
            // Test case ages
            List<int> ages = new List<int> { 5, 18, 30, 70 };

            try
            {
                // Categorize ages using a switch statement
                List<string> categories = new List<string>();
                foreach (int age in ages)
                {
                    string category;
                    if (age < 1)
                    {
                        throw new ArgumentException("Age cannot be less than 1.");
                    }
                    else if (age <= 14)
                    {
                        category = "Children";
                    }
                    else if (age <= 24)
                    {
                        category = "Youth";
                    }
                    else if (age <= 64)
                    {
                        category = "Adults";
                    }
                    else if (age >= 65)
                    {
                        category = "Seniors";
                    }
                    else
                    {
                        throw new ArgumentException("Invalid age.");
                    }
                    categories.Add(category);
                }

                // Print age categories
                for (int i = 0; i < ages.Count; i++)
                {
                    Console.WriteLine($"The person's age is {ages[i]} and  the {categories[i]} category.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}
