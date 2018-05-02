using System;
using System.Linq;

/* Write a program in C# Sharp to find the strings for a specific minimum length.
 * Test Data:
 * Input number of strings to store in the array: 4
 * Input 4 strings for the array:
 * Element[0]: this
 * Element[1]: is
 * Element[2]: a
 * Element[3]: string
 * Input the minimum length of the item you want to find: 5
 * Expected Output: The items of minimum 5 characters are :
 * Item: string */

namespace _20180327_Task3_LINQ2
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Input the number of words to be specified: ");
                int arraySize = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                string[] array = new string[arraySize];

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Word № {i + 1}: ");
                    array[i] = Console.ReadLine();
                }

                Console.Write("\nEnter the minimum number of characters in the word to search for it: ");
                int numberOfLetters = int.Parse(Console.ReadLine());

                var answer = from word in array
                             where word.Length >= numberOfLetters
                             select word;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\nA word(s) from {numberOfLetters} characters or more: \n");
                Console.ForegroundColor = ConsoleColor.Gray;
                foreach (string element in answer)
                    Console.WriteLine($"{element}");
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input Error!");
                Console.WriteLine("Please try again later...");
            }

            Console.ReadKey();
        }
    }
}