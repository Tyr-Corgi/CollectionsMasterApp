﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] array50 = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(array50);

            //TODO: Print the first number of the array
            Console.WriteLine($" The first number in your list is {array50.First()}");

            //TODO: Print the last number of the array
            Console.WriteLine($" The last number in your list is {array50[array50.Length - 1]}");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(array50);
            Console.WriteLine(array50);

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Array.Reverse(array50);
            NumberPrinter(array50);
            Console.WriteLine(array50);

            Console.WriteLine("Double Reversed.... now back to normal");
            ReverseArray(array50);

                Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(array50);
            NumberPrinter(array50);
            Console.WriteLine(array50);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(array50);
            NumberPrinter(array50);
            Console.WriteLine(array50);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            var numInput = new List<int>();

            //TODO: Print the capacity of the list to the console
            
            NumberPrinter(numInput);
            Console.WriteLine($"Test {numInput}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            //var num = new List<int>();

            //for (int i = 0; i < 150; i++)
            //{
            //    num.Add(i);
            //}
            //{
            //    foreach (var test in num)
            //        Console.WriteLine(test);
            //}

            Populater(numInput);

            //TODO: Print the new capacity
            Console.Write(numInput);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            int userNum;
            bool isANumber;

            do
            {
                Console.WriteLine();
                isANumber = int.TryParse(Console.ReadLine(), out userNum);
            }
            while (isANumber == false);
            NumberChecker(numInput, userNum);   
               Console.WriteLine("-------------------");
            

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
                OddKiller(numInput);
                NumberPrinter(numInput);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
                numInput.Sort();
                NumberPrinter(numInput);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var convertedArray = numInput.ToArray();

                //TODO: Clear the list
                numInput.Clear();
                NumberPrinter(numInput);

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
                for (var i = numberList.Count - 1; i >= 0; i--)
                {
                    if (numberList[i] % 2 != 0)
                    {
                        numberList.Remove(numberList[i]);
                    }
                }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"That number is indeed here");
            }
            else
            {
                Console.WriteLine("Sorry they are out for the moment");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            while (numberList.Count <= 50)
            {
                var number = rng.Next(0, 50);

                numberList.Add(number);
            }
            NumberPrinter(numberList);
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);
            }
        }

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            NumberPrinter(array);
            Console.WriteLine(array);
        }
        //var reversedArray = new int[array.Length];
        //var counter = 0;

        //for (int i = array.Length - 1; i >= 0; i--)
        //{
        //    reversedArray[counter] = array[i];
        //    counter++;
        //    //reversedArray[counter++] = array[i];




        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
