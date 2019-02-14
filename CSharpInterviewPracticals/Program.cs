﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Binary Search Tree
            Console.WriteLine("---------------***********------------");
            Console.WriteLine("1. Program for Binary search Tree");
            BinarySearchTree.Node n1 = new BinarySearchTree.Node(1, null, null);
            BinarySearchTree.Node n3 = new BinarySearchTree.Node(3, null, null);
            BinarySearchTree.Node n2 = new BinarySearchTree.Node(2, n1, n3);
            Console.WriteLine(BinarySearchTree.Contains(n2, 3));

            //User interface contains two types of user input controls: TextInput, which accepts all characters and NumericInput, which accepts only digits.
            Console.WriteLine("---------------***********------------");
            Console.WriteLine("2. Program to Find User interface");
            UserInput.TextInput input = new UserInput.NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());

            //Palindrome
            Console.WriteLine("---------------***********------------");
            Console.WriteLine("3. Program to Find Palindrome of any string");
            Console.Write("Enter The String to Validate as Palindrome:");
            string str = Console.ReadLine();
            if (Palindrome_with_ignorecase.IsPalindrome(str))
            {
                Console.WriteLine("Provided String is Palindrome");
            }
            else
            {
                Console.WriteLine("Provided String is not a Palindrome");
            }

            // Q.4 Print Star
            Console.WriteLine("---------------***********------------");
            Console.WriteLine("4. Program to print star in Odd numbers");
            StarPrint.OddStarPrint();

            // Q.5 Program to Swap Numbers Without Creating Temporary Variable
            Console.WriteLine("---------------***********------------");
            Console.WriteLine("5. Program to Swap Numbers Without Creating Temporary Variable");
            Console.Write("Enter the First No: ");
            int firstNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second No: ");
            int secondNo = Convert.ToInt32(Console.ReadLine());
            SwapNumWithoutTempVariable.SwapNumber(firstNo, secondNo);

            // Q.6 Program to duplicate string from the provided string
            Console.WriteLine("---------------***********------------");
            Console.WriteLine("6. Program to duplicate string from the provided string");
            Console.Write("Enter the String to Remove Duplicate: ");
            string str5 = Console.ReadLine();
            Console.WriteLine("The Result String is : {0}", RemoveDuplicateString.RemoveString(str5));

            // Q.7 Check Whether the Entered Number is an Armstrong or Not
            Console.WriteLine("---------------***********------------");
            Console.WriteLine("7. Program to Check Armstrong Number");
            Console.Write("Enter the Number to Check: ");
            int armNo = Convert.ToInt32(Console.ReadLine());
            if (NumIsArmstrongOrNot.IsArmstrong(armNo))
            {
                Console.WriteLine("Provided Number is an Armstrong number");
            }
            else
            {
                Console.WriteLine("Provided Number is not Armstrong number");
            }

            // Q.8 Find Factorial of the given number
            // We can find the factorial of a Number Using 3 different ways i.e. (Using For Loop, Using Recursion and Using While Loop)
            Console.WriteLine("---------------***********------------");
            Console.WriteLine("8. Program to find factorial of a number");
            Console.Write("Enter the Number to Find Factorial: ");
            int factorailNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Factorial of {0} is {1}", factorailNo, FactorialNo.ForLoop_Fact(factorailNo)); // Using For Loop
            //Console.WriteLine("The Factorial of {0} is {1}", factorailNo, FactorialNo.WhileLoop_Fact(factorailNo)); // Using While Loop
            //Console.WriteLine("The Factorial of {0} is {1}", factorailNo, FactorialNo.Recursive_Fact(factorailNo)); // Using Recursion

            Console.ReadKey();
        }
    }
}
