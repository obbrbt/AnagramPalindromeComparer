using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * References:
 * https://stackoverflow.com/questions/6441583/is-there-a-simple-way-that-i-can-sort-characters-in-a-string-in-alphabetical-ord
 * https://www.geeksforgeeks.org/check-whether-two-strings-are-anagram-of-each-other/
 * https://www.w3resource.com/csharp-exercises/string/csharp-string-exercise-12.php
 */

namespace AnagramPalindromeComparer
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Livvy's Anagram and Palindrome Comparer!");
			Console.WriteLine("This program takes in two strings and then compares them to see if they are anagrams of one another.");
			Console.WriteLine("And then it checks to see if each string is a palindrome.\n");
			Console.WriteLine("-----------------------------------------\n");
			Console.WriteLine("Please input string one: ");
			var inputOne = Console.ReadLine();
			inputOne.ToString();
			Console.WriteLine("Pleae input string two: ");
			var inputTwo = Console.ReadLine();
			inputTwo.ToString();

			var sortedInputOne = sortString(inputOne);
			var sortedInputTwo = sortString(inputTwo);
			if(isAnagram(sortedInputOne, sortedInputTwo))
			{
				Console.WriteLine("\n" + inputOne + " is an anagram of " + inputTwo);
			}
			else
			{
				Console.WriteLine("\n" + inputOne + " is not an anagram of " + inputTwo);
			}

			if(isPalindrome(inputOne))
			{
				Console.WriteLine("\n" + inputOne + " is a palindrome.");
			}
			else
			{
				Console.WriteLine("\n" + inputOne + " is not a palindrome.");
			}

			if(isPalindrome(inputTwo))
			{
				Console.WriteLine("\n" + inputTwo + " is a palindrom.");
			}
			else
			{
				Console.WriteLine("\n" + inputTwo + " is not a palindrome.");
			}
			Console.WriteLine("Press any key to continue.");
			Console.ReadKey();
		}

		public static string sortString(string input)
		{
			char[] charArray = input.ToArray();
			char temp;
			int length = charArray.Length;
			for(int i = 0; i < length; i++)
			{
				for(int j = 0; j < length - 1; j++)
				{
					if(charArray[j] > charArray[j + 1])
					{
						temp = charArray[j];
						charArray[j] = charArray[j + 1];
						charArray[j + 1] = temp;
					}
				}
			}
			return new string(charArray);
		}

		public static bool isPalindrome(string input)
		{
			var lastElement = 1;
			for (int i = 0; i < input.Length; i++)
			{
				if(input[i] != input[input.Length - lastElement])
				{
					return false;
				}
				lastElement++;
			}
			return true;
		}

		public static bool isAnagram(string inputOne, string inputTwo)
		{
			if(inputOne.Length != inputTwo.Length)
			{
				return false;
			}
			for(int i = 0; i < inputOne.Length; i++)
			{
				if(inputOne[i] != inputTwo[i])
				{
					return false;
				}
			}
			return true;
		}
	}
}
