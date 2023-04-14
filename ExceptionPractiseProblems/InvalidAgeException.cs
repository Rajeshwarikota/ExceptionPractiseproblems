using System;
using System.Runtime.Serialization;

namespace ExceptionPractiseProblems
{
    [Serializable]
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}