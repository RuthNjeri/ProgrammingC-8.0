using System;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiple variables in a single declaration
            double a = 1, b = 2.5, c = -3;

            // Variables holds information of a particular type
            // The compiler prevents another type from being re-assigned into 
            // The variable

            string part1 = "the ultimate question";
            string part2 = "of something";
            int theAnswer = 42;

            // Re-assign a variable with the same type
            part2 = "of life, the universe, and everything";

            string questionText = "What is the answer to " + part1 + ", " + part2 + "?";
            string answerText = "The answer to " + part1 + ", " + part2 + " is:" + theAnswer;

            Console.WriteLine(questionText);
            Console.WriteLine(answerText);
            Console.ReadLine();

            // The compiler will raise an error if you try to use a variable before you have assigned it

            int willNotWork;
            Console.WriteLine(willNotWork);
            

            // The compiler uses a highly pessimistic system(definite assignment rules) 
            // for determining whether a variable has a value yet.

            // There are situations where the compiler complains and the variable might have a value by the time the
            // offending code runs. In such situations, the solution is to initialize the variable
            // int test = 0; bool isPresent = false;

            // Chapter_3 has reference types. Holds a reference to an instance of the type.
            // If you need to initialize a variable before you have a reference to it, you can use the keyword null.
            // a special value signifying reference to nothing.

            // Definite assignement rules determine parts of your code in which the compiler considers a variable
            // to contain a valid value and will let you read from it.

            // Writing from a variable is less restricted but there certain parts of the code where a given variable is
            // accessible

            // SCOPE
        }
    }
}
