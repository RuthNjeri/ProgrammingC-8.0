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

            SomeMethod();
            AnUncompilableMethod();
            NestedScope();
            VariableAmbiguity();

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
                // Console.WriteLine(anotherValue);
                // Causes an error because the variable has been used in the external block.
                // It is not a scope issue but a conflicting names issue.
                // int anotherValue = someValue - 100;
                
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
                // Then this line of code: int errorCount = 1; Compiler error
                if (problem3)
                {
                    errorCount += 1;
                }
            }

            // LOCAL VARIABLE INSTANCES
            // Each variable has a distinct identity.
            // It is declared in exactly one place and goes out of scope at exactly one well-defined place.
            // It doesn't usually correspond to a single storage location in memory.
            // It is possible for multiple invocations of a single method to be in progress simultaneously: recursion, multithreading
            // and asynchronous execution.

            // Each time a method runs, it gets a distinct set of storage locations to hold the local variables' values
            // enabling multiple threads to execute the same method simultaneously without problems.
            // because each has it's own set of local variables.
            // Likewise, each nested call gets its own set of locals that will not interfere with any of its callers.
            // Each execution of a particular scope gets its own set of variables

            // C# reuses storage locations when it can for optimization
            // eg it will not allocate new memory for variables declared in the body of a loop for each iteration unless
            // you put in a situation where it has no choice, but the effect is as though it allocated new space each time

            // C# does not guarantee where variables will live. Sometimes in a stack, but sometimes they don't.
            // Sometimes variables need to outlive the method that declares them.
            // They remain in scope for nested methods that will run as callbacks after the containing method has returned.


            // STATEMENTS AND EXPRESSIONS
            // A C# method is a sequence of statements describing actions that we want the method to perform.
            // There are 13 categories of statements.

            // Declaration Statements
            int a = 19;
            int b = 23;
            int c;

            // Expression statements
            c = a + b;
            Console.WriteLine(c);

            // A loop is an iteration statement.
            // if and switch are selection statements.
            // A block is a kind of statement.

            int d = 19;
            int e = 23;
            {
                int f;
                f = d + e;
                Console.WriteLine(f);
            }

            // EXPRESSIONS
            // Literals are the simplest expression.
            // where we just write the value we want like "Hello", "42"
            // A variable name can also be used as an expression.
            // Expressions can involve operators, describing calculations or computations to be performed.
            // Operators have fixed number of inputs called operands.
            // Operands are also expressions. 2 + 2 is an expression containing two more expressions, 2 and 2.

            // Expressions within expressions
            double g = 1, h = 2.5, i = -3;

            // Contains a parenthesized expression, which has a
            double x = (-h + Math.Sqrt(h * h - 4 * g * i)) / 2 * g;
            Console.WriteLine(x);

            // Method invocation is allowed to be an expression statement

            Console.WriteLine("Hello world!");
            Console.WriteLine(13 + 30);
            Console.ReadKey();
            Math.Sqrt(4);

            // C# allows any method as an expression.
            // Some expressions do not work as statements
            //Console.ReadKey().KeyChar + "!";
            //Math.Sqrt(4) + 3;

            // Assignments are expressions
            // They produce a value, the value being assigned to the variable.

            int number;
            Console.WriteLine(number = 23);
            Console.WriteLine(number);

            int j, k;
            j = k = 0;

            Console.WriteLine(j);
            Console.WriteLine(k);

        }
    }
}