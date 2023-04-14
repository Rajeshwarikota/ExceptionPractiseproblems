using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractiseProblems
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
            Console.WriteLine(" Enter the valid age");
        }
    }
}
