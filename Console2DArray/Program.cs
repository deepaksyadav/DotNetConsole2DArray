using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a 2D Array with 4 Rows and 5 Columns
            int[,] RectangleArray = new int[4, 5];

            // Creating a 2D Array and initiallizing at the same time;
            int[,] A = new int[2, 3]
            { 
                {2, 5, 9},
                {6, 9, 15}
            };

            foreach (int i in A)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");


            int a = 0;
            //Printing the values of 2D array using foreach loop
            //It will print the default values as we are not assigning
            //any values to the array
            foreach (int i in RectangleArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            //Assigning values to the 2D array by using nested for loop
            //arr.GetLength(0): Returns the size of the Row
            //arr.GetLength(1): Returns the size of the Column
            for (int i = 0; i < RectangleArray.GetLength(0); i++)
            {
                for (int j = 0; j < RectangleArray.GetLength(1); j++)
                {
                    a += 5;
                    RectangleArray[i, j] = a;
                }
            }
            //Printing the values of array by using nested for loop
            //arr.GetLength(0): Returns the size of the Row
            //arr.GetLength(0): Returns the size of the Column
            for (int i = 0; i < RectangleArray.GetLength(0); i++)
            {
                for (int j = 0; j < RectangleArray.GetLength(1); j++)
                {
                    Console.Write(RectangleArray[i, j] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
