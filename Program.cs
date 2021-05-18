using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

           

            // ------------------------------------------------------------------------------------------------------------
            // Question 1
             question_1();


            // ------------------------------------------------------------------------------------------------------------
            // Question 2
            question_2();


            // ------------------------------------------------------------------------------------------------------------
            // Question 3
            question_3();


            // ------------------------------------------------------------------------------------------------------------
            // Question 4
            question_4();


            // ------------------------------------------------------------------------------------------------------------
            // Question 5
            question_5();


            // ------------------------------------------------------------------------------------------------------------
            // Question 6
            question_6();


            // ------------------------------------------------------------------------------------------------------------
            // End 
            Console.WriteLine("Press <Enter> to terminate program");
            Console.ReadLine();

        }


        public static void question_1()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Question #1:");
            Console.WriteLine("Professor Agrawal receives an array of integer points sorted in ascending order, the task is to find the initial");
            Console.WriteLine("and final index of a given target point’s value.If the target point value is not found in the array of integers, ");
            Console.WriteLine("return [-1, -1].  The professor had to leave for a conference at short notice and asked you to complete ");
            Console.WriteLine("the task for him.  He instructed you to limit the time complexity to O(n).");
            Console.WriteLine();

            int first, last;
            Console.Write("Enter numeric items separated by commas: ");
            string marks_input = Console.ReadLine();
            Console.Write("Enter target numeric value (n): ");
            string target = Console.ReadLine();
            string[] marks = marks_input.Split(',');
            first = Array.IndexOf(marks, target) + 1;
            last = Array.LastIndexOf(marks, target) + 1;
            first = (first != 0 ? first : -1);
            last = (last != 0 ? last : -1);
            Console.WriteLine("[" + first.ToString() + "," + last.ToString() + "]");
            Console.WriteLine();
        }




        public static void question_2()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Question #2:");
            Console.WriteLine("Rocky is not aware of the inbuilt functions to split and reverse a string. He is given a string");
            Console.WriteLine("and he needs to reverse the order of characters in each word within a sentence while still preserving whitespace");
            Console.WriteLine("and initial word order. He is not allowed to use any predefined split and reverse function.");
            Console.WriteLine("He is requesting you to complete the method for him.");
            Console.WriteLine();

            Console.Write("Enter sentence for which each word will be reversed: ");
            string in_string = Console.ReadLine();
            char delimeter = ' ';
            // Custom SplitString function
            string[] words = SplitString(in_string, delimeter);
            foreach (string x in words)
            {
                // Custom ReverseString function
                Console.Write(ReverseString(x) + delimeter);
            }
            Console.WriteLine();
            Console.WriteLine();
        }



        public static void question_3()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Question #3: NEEDS WORK!");
            Console.WriteLine("Professor Stablein is given a sorted integer array. He needs to make the array elements");
            Console.WriteLine("distinct by increasing each value as needed, while minimizing the array sum. Professor");
            Console.WriteLine("Stablein thought this was an interesting exercise that the students might enjoy completing.");
            Console.WriteLine(" Your job is to complete the method to print the minimum possible sum as output");
            Console.WriteLine();

            Console.WriteLine("Enter numbers separated by commas: ");
            Console.WriteLine("NEEDS WORK!");
            Console.WriteLine();
        }



        public static void question_4()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Question #4:");
            Console.WriteLine("You are given a string and your task is to sort the given string in decreasing order of");
            Console.WriteLine("frequency of occurrence of each character.");
            Console.WriteLine();


            Console.Write("Enter the word to assess: ");
            string word = Console.ReadLine();   // Read the Input string from User at Run Time  
            Dictionary<char, int> CharacterCount = new Dictionary<char, int>();

            //Add character to dictionary
            for (int i = 0; i < word.Length; i++) //loop the splited string  
            {
                if (CharacterCount.ContainsKey(word[i])) // Check if word already exist in dictionary update the count  
                {
                    CharacterCount[word[i]]++;
                }
                else
                {
                    CharacterCount.Add(word[i], 1);  // if a string is repeated and not added in dictionary , here we are adding   
                }
            }

            // Order dictionary items by descending value
            var items = from pair in CharacterCount
                        orderby pair.Value descending
                        select pair;

            // Display results.
            foreach (KeyValuePair<char, int> pair in items)
            {
                for (int i = 1; i <= pair.Value; i++)
                {
                    Console.Write(pair.Key);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }



        public static void question_5()
        {

            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Question #5: NEEDS WORK!");
            Console.WriteLine("Rocky the Bull is new to programming and is having trouble understating the importance of");
            Console.WriteLine("time complexity. Professor Agrawal assigned you the job of explaining time complexity to");
            Console.WriteLine("Rocky with the example below.");
            Console.WriteLine();

            Console.WriteLine("Enter first array of numbers separated by commas: ");
            Console.WriteLine("NEEDS WORK!");
            Console.WriteLine();
        }



        public static void question_6()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Question #6:");
            Console.WriteLine("You are given an array of characters and an integer k, and are required to find out whether there are");
            Console.WriteLine("two distinct indices i and j in the array such that arr[i]=arr[j]");
            Console.WriteLine("and the absolute difference between i and j is at most k.");
            Console.WriteLine();
            Console.Write("Enter first array of characters separated by commas: ");
            string input_string = Console.ReadLine();
            string[] temp_array = input_string.Split(',');
            int k = 0;
            Console.Write("Enter absolute difference numeric value (k): ");
            string input_k = Console.ReadLine();
            try
            {
                k = Convert.ToInt32(input_k);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            bool response = false;
            for (int i = 0; i < temp_array.Length - 1; i++)
            {
                for (int j = i + 1; j < temp_array.Length; j++)
                {
                    if (temp_array[i] == temp_array[j])
                    {
                        if ((j - i).Equals(k))
                        {
                            response = true;
                        }
                    }
                }
            }
            Console.WriteLine("Response is " + response.ToString());
            Console.WriteLine();
        }
            


        public static string[] SplitString(string in_string, char delimiter)
        {
            List<String> words = new List<String>();
            int start = 0;

            // Split into words
            for (int i = 0; i < in_string.Length; i++)
            {
                if (in_string[i] == delimiter)
                {
                    words.Add(in_string.Substring(start, i - start));
                    start = i + 1;
                }
            }
            words.Add(in_string.Substring(start, in_string.Length - start));
            return words.ToArray();
        }



        public static string ReverseString(string in_string)
        {

            string out_string = String.Empty;

            for (int i = in_string.Length - 1; i > -1; i--)
            {
                out_string = out_string + in_string[i];

            }
            return out_string;
        }



    }
}
