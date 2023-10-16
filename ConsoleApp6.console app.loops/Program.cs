using System;
using System.Buffers.Text;
using System.Data;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;

namespace ConsoleApp6.console_app.loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1.arraydeki tekrarlanan ededleri tap

           


            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;


                if (array[i] == -1)
                {
                    continue;
                }

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        if (i != j)
                        {

                            array[j] = -1;
                        }
                    }
                }

                Console.WriteLine(array[i] + " ededinden " + count + " dene");
            }



























            #endregion


            #region task2.Console app:
            Console.WriteLine("Enter the length of the array: ");
            string arrays = Console.ReadLine();
            int arry = Convert.ToInt32(arrays);
            Console.WriteLine("You want to enter a new numbers(yes/no): ");
            string input = Console.ReadLine();

            if (input == "yes" || input == "y")
            {

                Console.WriteLine("I want to add an item");
            }
            else if (input == "no" || input == "n")
            {

                Console.WriteLine("I don't want to add an item");
            }
        }
    }
}
    
     #endregion
    