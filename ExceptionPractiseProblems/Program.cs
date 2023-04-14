using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractiseProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....Exception....");
            Console.WriteLine("\n1:Age Determination\n2:Null\n3:custom Exception\n22:default");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    int age = 30;
                    string category = PersonCategory.GetCategory(age);
                    Console.WriteLine($"The person's age is {age} and belongs to {category} category.");
                    break;
                //case 2:
                //    int? value = null;
                //    string cat = PersonCategory.GetCategory(value);
                //    Console.WriteLine($"The person's age is {value} and the category is {cat}.");
                //    break;
                //case 3:
                //    int? v = -1;
                //    string c = PersonCategory.GetCategory(v);
                //    Console.WriteLine($"The person's age is {v} and the category is {c}.");
                //    break;
                default:
                    Console.WriteLine("choose the above option");
                    break;
            }
            Console.ReadLine();

        }
    }
}
