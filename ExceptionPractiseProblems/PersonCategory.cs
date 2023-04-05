using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractiseProblems
{
    public class PersonCategory
    {
        public static string GetCategory(int? age)
        {
            string category;

            try
            {
                if (age == null)
                {
                    throw new ArgumentNullException(nameof(age), "Age cannot be null.");
                }
                else if (age < 1)
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
                    throw new ArgumentException("Invalid age entered.");
                }
            }
            catch (ArgumentNullException ex)
            {
                category = "Error: " + ex.Message;
            }
            catch (ArgumentException ex)
            {
                category = "Error: " + ex.Message;
            }
            return category;
        }
    }
}






