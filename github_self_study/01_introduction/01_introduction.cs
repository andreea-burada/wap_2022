/*----- GitHub 1 - C# & .NET Framework Bascis -----*/

// basic form of a program
// namespace -> class -> main function
// namespace name: whatever we want
// class name: Program
// main function name: Main

using System;               // referenced namespace
using System.Diagnostics;   // for Stopwatch
using System.Text;          // for StringBuilder

namespace MyFirstProgram
{
    internal class Program
    {
        // the main function can return void or int
        // using int you can return arbitrary error codes

        //private static int Main(string[] args)
        private static void Main(string[] args)
        {
            // --- ways of writing on the console ---
            Console.WriteLine("Hello World!");

            Console.Write("Name? ");
            String name;
            //name = Console.ReadLine();
            name = "Andreea";

            Console.WriteLine("Hi, {0}!", name);

            Console.WriteLine($"Hello, {name}!");   //C#6+ only

            Console.WriteLine("Salut, " + name + "!");

            Console.Write("Buna, ");
            Console.Write(name);
            Console.Write("!\n");

            int number = 11;
            Console.WriteLine("C lang. format: {0:d} {1:s} {2:f}", number, "Test", 12.3);

            // --- returning a specific return code ---
            //return -1;      // only when the Main return type is int

            // --- main function arguments ---
            // main functions also take arguments (array of strings)
            Console.WriteLine("No. of args: " + args.Length);
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine("Argument no. " + i + " : " + args[i]);

            foreach (string arg in args)
            {
                Console.WriteLine("Argument: {0}", args);
            }

            // calling SystemDataTypes
            SystemDataTypes();

            // calling StringTypes
            StringTypes();

            // calling StringBuilderType
            //StringBuilderType();

            // calling ArrayType
            ArrayType();

        }   // end main


        
        private static void SystemDataTypes()
        {
            // --- data types ---
            /*
             Data types can be of two kinds: VALUE or REFERENCE

            --- VALUE TYPES --- 
            struct, enum, primitive types (bool, int etc.) derived from System.ValueType
            -> allocated on the stack
            -> can be created and destroyed very quickly; lifetime determined by the defining scope

            --- REFERENCE TYPES ---
            class, delegate, interface
            -> allocated in the heap
            -> lifetime is determined by a large number of factors

            // you can use "var" instead of the type
             */

            Console.Write("Your message: ");
            //string message = Console.ReadLine();
            //var message = Console.ReadLine();
            var message = "Outside it is cloudy";

            // one data type that is new is DateTime
            //DateTime currentTime = DateTime.Now;
            var currentTime = DateTime.Now;

            Console.WriteLine("\nMessage: {0}\nCurrent time: {1}\nGood-bye!", 
                message, currentTime.ToString("dd - MMMM - yy HH:mm"));
        }

        private static void StringTypes()
        {
            // strings are IMMUTABLE -> once you set them a value, you cannot change it
            // the change that seems to be happening is in fact a brand new string
            string s1 = "abcde";
            string s2 = s1;
            //s1 = "zyx";
            s1 = s1.Replace("abcde", "ababab");

            Console.WriteLine("s1: " + s1);
            Console.WriteLine("s2: " + s2);

            String S1 = "abcde";
            String S2 = S1;
            S1 += "f";

            Console.WriteLine("\nS1: " + S1);
            Console.WriteLine("S2: " + S2 + "\n");

            // operator== is overloaded for string and String; works like strcmp
            string a = "hello";
            string b = "h";
            b += "ello";

            Console.WriteLine(a == b);
            Console.WriteLine(S1 == S2);
            // changing S1 to an object type will return False because they are different types
            Console.WriteLine((object)S1 == S2);

            Console.WriteLine("");

        }

        public static void StringBuilderType()
        {
            // mutable string class
            // used when strings are changed a lot of times
            // mutability = once an instance of a class has been created, it can be modified by appending,
            //              removing, replacing or inserting characters
            // usage example: email containing phone logs or calendar entries, text based reports

            // --- performance measurning example ---
            Console.WriteLine("###StringBuilderPerformance");

            const int noOfRepetitions = 100000;

            var regularString = string.Empty;

            // For a more precise measurement, use a performance counter instead of a Stopwatch
            var watch = Stopwatch.StartNew();
            for (var i = 0; i < noOfRepetitions; i++)
            {
                regularString += "a";
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine("Using System.String: {0}ms", elapsedMs);

            var stringBuilder = new StringBuilder();

            watch = Stopwatch.StartNew();
            for (var i = 0; i < noOfRepetitions; i++)
            {
                stringBuilder.Append("a");
            }
            regularString = stringBuilder.ToString();
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine("Using System.Text.StringBuilder: {0}ms", elapsedMs);

        }

        public static void ArrayType()
        {
            // stored in a contiguous block of memory
            // all arrays inherit from the System.Array class
            // important inherited methods and properties:
            /*
                - Length : number of elements
                - GetLength(dim): 32-bit int that repr. the number of elements in that specified dimension of the Array
                - Rank: get the number of dimensions
                - Clone(): creates a shallow copy of the Array
             */
            // creating an array always pre-initializes the elements with default values
            //  NULL for reference types; 0 for numeric types

            int[] intArray;
            // we must allocate space
            intArray = new int[3]; // all values will be 0
            foreach (int val in intArray)
                Console.Write($"{val} ");

            Console.WriteLine("");

            var doubleArray = new[] { 32.1, 14.5, 16.7, 19.8 };
            Array.Sort(doubleArray);    // Array.Sort works only if IComparible was implemented
            for (int i = 0; i < doubleArray.Length; i++)
                Console.Write(doubleArray[i] + " ");
            Console.WriteLine("\n");

            // --- multidimensional arrays ---
            var matrix = new int[,] {
                {1, 2, 3},
                {3, 2, 1},
                {1, 3, 2},
                {3, 1, 2}
            };

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // --- jagged matrixes ---
            int[][] jaggedMatrix =
            {
                new int[] {1, 2, 3},
                new int[] {1, 2},
                new int[] {1, 2, 3, 4}
            };

            for (var i = 0; i < jaggedMatrix.GetLength(0); i++)
            {
                for (var j = 0; j < jaggedMatrix[i].Length; j++)
                {
                    Console.Write(jaggedMatrix[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }   // end class

}   // end namespace
