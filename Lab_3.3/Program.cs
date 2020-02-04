using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            
            do
            {
                Console.WriteLine("enter a word:");
                userInput = Console.ReadLine();

                if (ValidInput(userInput))
                {

                    string[] wordsSplit = userInput.Split(" ");

                    foreach (var word in wordsSplit)
                    {
                        Console.Write($"{ReverseWord(word)} ");
                    }
                    
                }
                
            } while (ValidInput(userInput) == false);

    {

            }
        }

        public static string ReverseWord(string input)
        {
            Stack<char> stack = new Stack<char>();

            char[] wordArry = input.ToCharArray();

            for (int i = 0; i < wordArry.Length; i++)
            {
                stack.Push(wordArry[i]);
            }

            for (int i = 0; i < wordArry.Length; i++)
            {
                wordArry[i] = stack.Pop();
            }

            string reversedWord = new string (wordArry);

            return reversedWord;
        }

        static bool ValidInput(string input)
        {
            string pattern = @"^[A-Za-z ]*$";


            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
