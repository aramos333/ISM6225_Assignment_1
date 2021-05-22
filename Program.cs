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
            Console.Write("Press <Enter> to terminate program");
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

            Console.Write("Enter numeric items separated by commas: ");
            string marks_input = Console.ReadLine();
            Console.Write("Enter target numeric value (n): ");
            string target_input = Console.ReadLine();

            int target = Convert.ToInt32(target_input);
            string[] temp_array = marks_input.Split(',');
            //int[] marks = new int[temp_array.Length];

            int[] marks = Convert2NumericArray(temp_array);



            // Use targetRange()
            int[] results = targetRange(marks, target);
            Console.WriteLine("Results: [{0}]", string.Join(", ", results));
            Console.WriteLine();
            Console.Write("Press <Enter> to continue...");
            Console.ReadLine();


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
            string[] words = StringSplit(in_string, delimeter);
            foreach (string word in words)
            {
                // Use ReverseString()
                Console.Write(StringReverse(word) + delimeter);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Press <Enter> to continue...");
            Console.ReadLine();
        }






        public static void question_3()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Question #3:");
            Console.WriteLine("Professor Stablein is given a sorted integer array. He needs to make the array elements");
            Console.WriteLine("distinct by increasing each value as needed, while minimizing the array sum. Professor");
            Console.WriteLine("Stablein thought this was an interesting exercise that the students might enjoy completing.");
            Console.WriteLine(" Your job is to complete the method to print the minimum possible sum as output");
            Console.WriteLine();

            Console.Write("Enter sorted numbers separated by commas: ");
            string input = Console.ReadLine();
            string[] temp_array = input.Split(',');
            int[] numbers = new int[temp_array.Length];
            for (int i = 0; i < numbers.Length; ++i)
                numbers[i] = Convert.ToInt32(temp_array[i]);

            // Use of minSum()
            Console.WriteLine("The minimum sum is: " + minSum(numbers).ToString());
            Console.WriteLine();
            Console.Write("Press <Enter> to continue...");
            Console.ReadLine();
        }






        public static void question_4()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Question #4:");
            Console.WriteLine("You are given a string and your task is to sort the given string in decreasing order of");
            Console.WriteLine("frequency of occurrence of each character.");
            Console.WriteLine();


            Console.Write("Enter the word to assess: ");
            string word = Console.ReadLine();

            // Use FreqSort()
            Console.WriteLine(FreqSort(word));
            Console.WriteLine();
            Console.Write("Press <Enter> to continue...");
            Console.ReadLine();
        }






        public static void question_5()
        {

            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Question #5:");
            Console.WriteLine("Rocky the Bull is new to programming and is having trouble understating the importance of");
            Console.WriteLine("time complexity. Professor Agrawal assigned you the job of explaining time complexity to");
            Console.WriteLine("Rocky with the example below.");
            Console.WriteLine();

            Console.Write("Enter first array of integers separated by commas: ");
            string input_string = Console.ReadLine();
            string[] string_array1 = input_string.Split(',');
            int[] array1 = Convert2NumericArray(string_array1);

            Console.Write("Enter second array of integers separated by commas: ");
            input_string = Console.ReadLine();
            string[] string_array2 = input_string.Split(',');
            int[] array2 = Convert2NumericArray(string_array2);

            // Sort numeric arrays
            Array.Sort(array1);
            Array.Sort(array2);

            if (array1.Length <= array2.Length)
            {
                Console.WriteLine("Results using built-in function : [{0}]", string.Join(", ", Intersect0(array1, array2)));
                Console.WriteLine("Results using Array             : [{0}]", string.Join(", ", Intersect1(array1, array2)));
                Console.WriteLine("Results using Dictionary        : [{0}]", string.Join(", ", Intersect3(array1, array2)));
            }
            else
            {
                Console.WriteLine("Results using built-in function : [{0}]", string.Join(", ", Intersect0(array2, array1)));
                Console.WriteLine("Results using Array             : [{0}]", string.Join(", ", Intersect1(array2, array1)));
                Console.WriteLine("Results using Dictionary        : [{0}]", string.Join(", ", Intersect3(array2, array1)));
            }
            Console.WriteLine();
            Console.Write("Press <Enter> to continue...");
            Console.ReadLine();
        }






        public static void question_6()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Question #6:");
            Console.WriteLine("You are given an array of characters and an integer k, and are required to find out whether there are");
            Console.WriteLine("two distinct indices i and j in the array such that arr[i]=arr[j]");
            Console.WriteLine("and the absolute difference between i and j is at most k.");
            Console.WriteLine();

            // Get string to process
            Console.Write("Enter first array of characters separated by commas: ");
            string input_string = Console.ReadLine();
            char[] char_array = input_string.Replace(",", "").ToCharArray();

            // Get numeric index
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

            // Assess character array
            bool response = ContainsDuplicate(char_array, k);
            Console.WriteLine("Response is " + response.ToString());
            Console.WriteLine();
        }






        // Used in question #1
        public static int[] targetRange(int[] marks, int target)
        {
            int[] results = new int[2];
            results[0] = Array.IndexOf(marks, target);
            results[1] = Array.LastIndexOf(marks, target);
            return results;
        }






        // Used in question #2
        public static string[] StringSplit(string in_string, char delimiter)
        {
            // splits string where it finds the provided delimeter

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






        // Used in question #2
        public static string StringReverse(string in_string)
        {
            // reverses the order of characters in a string
            string out_string = String.Empty;

            for (int i = in_string.Length - 1; i > -1; i--)
            {
                out_string = out_string + in_string[i];

            }

            return out_string;
        }






        // Used in question #3
        public static int minSum(int[] arr)
        {
            Dictionary<int, int> MinimumSum = new Dictionary<int, int>();
            int sum = 0;

            //Add character to dictionary
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    j = arr[i];
                    while (MinimumSum.ContainsKey(j))
                    {
                        j++;
                    }
                    MinimumSum.Add(j, j);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            // Compute sum of values in the dictionary
            foreach (KeyValuePair<int, int> item in MinimumSum)
            {
                sum = sum + item.Value;
            }

            return sum;
        }






        // Used in question #4
        public static string FreqSort(string s)
        {
            Dictionary<char, int> CharacterCount = new Dictionary<char, int>();
            string output = String.Empty;

            //Add character to dictionary
            for (int i = 0; i < s.Length; i++)
            {
                if (CharacterCount.ContainsKey(s[i]))
                {
                    CharacterCount[s[i]]++;
                }
                else
                {
                    CharacterCount.Add(s[i], 1);
                }
            }

            // Order dictionary items by descending value
            var items = from pair in CharacterCount
                        orderby pair.Value descending
                        select pair;

            // compile output string
            foreach (KeyValuePair<char, int> pair in items)
            {
                for (int i = 1; i <= pair.Value; i++)
                {
                    output = output + pair.Key;
                }
            }

            return output;
        }






        // Used in question #5
        public static int[] Intersect0(int[] nums1, int[] nums2)
        {
            // Using built-in function
            return nums1.Intersect(nums2).ToArray();
        }






        // Used in question #5
        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            // Using array
            int[] results = new int[nums2.Length];

            // Initial pointers and results for merge check.
            int x = -1;
            bool found = false;
            for (int i = 0; i < nums1.Length; i++)
            {
                found = false;
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i].Equals(nums2[j]))
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    x++;
                    results[x] = nums1[i];
                }
            }
            Array.Resize(ref results, x + 1);
            return results;
        }






        // Not used - only detects distinct values
        // Used in question #5
        public static int[] Intersect2(int[] nums1, int[] nums2)
        {
            // Using dictionary data structure
            Dictionary<int, bool> Intersection = new Dictionary<int, bool>();

            //Add smaller array items to dictionary
            for (int j = 0; j < nums1.Length; j++)
            {
                if (!Intersection.ContainsKey(nums1[j]))
                {
                    Intersection.Add(nums1[j], false);
                }
            }

            //Process larger array items against dictionary
            for (int j = 0; j < nums2.Length; j++)
            {
                if (Intersection.ContainsKey(nums2[j]))
                {
                    Intersection[nums2[j]] = true;
                }
            }

            // Compile array of matched entries
            int intersection_count = Intersection.Count(kv => kv.Value.Equals(true));
            int[] results = new int[intersection_count];
            int i = -1;
            foreach (KeyValuePair<int, bool> item in Intersection)
            {
                if (item.Value.Equals(true))
                {
                    i++;
                    results[i] = item.Key;
                }
            }
            return results;
        }




        // Used in question #5
        public static int[] Intersect3(int[] nums1, int[] nums2)
        {
            // Using dictionary data structure
            Dictionary<int, int> Intersection = new Dictionary<int, int>();

            // compare each item in array 1 to each item in array 2.
            bool found = false;
            for (int i = 0; i < nums1.Length; i++)
            {
                found = false;
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i].Equals(nums2[j]))
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    Intersection.Add(i, nums1[i]);
                }
            }

            // Compile array of matched entries
            int[] results = new int[Intersection.Count];
            int n = -1;
            foreach (KeyValuePair<int, int> item in Intersection)
            {
                n++;
                results[n] = item.Value;
            }
            return results;
        }



        // Used in question #6
        public static bool ContainsDuplicate(char[] arr, int k)
        {
            bool response = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    // if the values of array positions are the same, check if 
                    // the difference of indexes equal k
                    if (arr[i] == arr[j])
                    {
                        if ((j - i).Equals(k))
                        {
                            response = true;
                        }
                    }
                }
            }
            return response;
        }






        public static int[] Convert2NumericArray(string[] input)
        {
            // takes a string of numeric values and returns an array of integers
            int[] results = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    results[i] = Convert.ToInt32(input[i]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return results;
        }

    }

}

/*
//Carla Bertoli - Question 1 
using System;
public static class Extensions
{
    public static int findIndex<T>(this T[] array, T item)
    {
        return Array.IndexOf(array, item);
    }
}

namespace FirstDraft 
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers:");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int D = Convert.ToInt32(Console.ReadLine());
            int E = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int[] array = { A, B, C, D, E };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter your variable ");
            int target_var = Convert.ToInt32(Console.ReadLine());

            int index = array.findIndex(target_var);
            if (index != -1)
            {
                Console.WriteLine(String.Format("[{0},{1}]", index, Array.LastIndexOf(array, target_var)));
            }
            else
            {
                Console.WriteLine("[-1,1]");
            }
        }
   */
//Carla Bertoli - Question 2 -- This is my first attempt since it still contains the reversestring. 
/*using System;
class Program
{
    static void Main(string[] args)
    {
        string Str, reversestring = "stisverinU fo htuoS adirolF";
        int Length;
        Console.Write("University of South Florida : ");
        Str = Console.ReadLine();
        Length = Str.Length - 1;
        while (Length >= 0)
        {
            reversestring = reversestring + Str[Length];
            Length--;
        }
        Console.WriteLine("Reverse  String  Is  {0}", reversestring);
        Console.ReadLine();
    }
}

*/
/* Carla Bertoli - Question 3 
using System;
class GFG
{
    static int minSum(int[] arr, int n)
    {
        int sum = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                int j = i;
                while (j < n && arr[j] <= arr[j - 1])
                {
                    arr[j] = arr[j] + 1;
                    j++;
                }
            }
            sum = sum + arr[i];
        }
        return sum;
    }
    public static void Main()
    {
        int[] arr = { 2, 2, 3, 5, 6 };
        int n = arr.Length;
        Console.WriteLine(minSum(arr, n));
    }
}
*/

/*Carla Bertoli - Question 4 - Without the dictionary. Unable to make that piece work at this time. 
using System;

class GFG
{
    static void descOrder(char[] s)
    {
        Array.Sort(s);
        reverse(s);
    }
    static void reverse(char[] a)
    {
        int i, n = a.Length;
        char t;
        for (i = 0; i < n / 2; i++)
        {
            t = a[i];
            a[i] = a[n - i - 1];
            a[n - i - 1] = t;
        }
    }
    public static void Main(String[] args)
    {
        char[] s = "TheCatintheHat".ToCharArray();
        descOrder(s); 
        Console.WriteLine(String.Join("", s));
    }
}
*/
