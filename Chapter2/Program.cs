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
            // The code below will not work

            int willNotWork;
            // Console.WriteLine(willNotWork);
            

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

        }

        // SCOPE
        // Range of code that you can refer that variable by name without needing any qualification.
        // Methods, properties, types, and anything with a name also has scope.
        // Example: Console.WriteLine needs to be qualified by the class name Console. The method WriteLine, is not in scope
        // With a local variable, scope is absolute, either it is accessible without qualification, or not accessible at all.
        // Variable scope starts at its declaration and finishes at the end of the containing block "{}"

        static void SomeMethod()
        {
            int thisWillNotWork = 42;
            
        }

        static void AnUncompilableMethod()
        {
            // Out of scope variable. 
            // Console.WriteLine(thisWillNotWork);
        }

        // Everything in scope in the outer block continues to be in scope in a nested block
        static void NestedScope()
        {
            int someValue = 10;
            if (someValue > 100)
            {
                Console.WriteLine(someValue);
            }

            // A variable inside a nested block cannot extend outside of that block
            int anotherValue = 20;
            if (anotherValue > 100)
            {
                int willNotWork = anotherValue - 100;
            }

            //Console.WriteLine(WillNotWork);
        }

        // Variable Name Ambiguity
        static void VariableAmbiguity()
        {
            int someValue = 10;
            if (someValue > 100)
            {
                // Causes an error because the variable has been used in the external block
                // int anotherValue = someValue - 100;
                // Console.WriteLine(anotherValue);
            }

            int anotherValue = 123;

            // C# prevents ambiguity by disallowing code where one name might refer to more than one thing
            // It does this to avoid misunderstanding of code.
            // The rule that disallows this is called declaration space.
            // A single name must not refer to two different entities
            int errorCount = 0;
            bool problem1 = false, problem2 = false, problem3 = false;

            if (problem1)
            {
                errorCount += 1;

                if (problem2)
                {
                    errorCount += 1;

                }

                // Imagine big chunks of code here


               // int errorCount = 1; Compiler error
                if (problem3)
                {
                    errorCount += 1;
                }
            }

        }
    }
}
