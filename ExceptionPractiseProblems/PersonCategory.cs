using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractiseProblems
{
    public class PersonCategory
    {
        public static string GetCategory(int age)
        {
                string category;

                try
                {
                    if (age >= 1 && age <= 14)
                    {
                        category = "Children";
                    }
                    else if (age >= 15 && age <= 24)
                    {
                        category = "Youth";
                    }
                    else if (age >= 25 && age <= 64)
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
                catch (ArgumentException ex)
                {
                    category = "Error: " + ex.Message;
                }
                return category;
        }
    }
}


    

