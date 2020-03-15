using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
   public class Program
    {
        /// <summary>
        /// the method takes a list of integers and
        /// filters the list so that only numbers remain on the output,
        /// containing the given digit.
        /// </summary>
        /// <param name="numbers"> array of numbers</param>
        /// <param name="digit"> filter condition</param>
        /// <returns>
        /// array of numbers
        /// containing the given digit.
        /// </returns>

        public static int[] FilterDigit(int[] numbers, byte digit)
        {
            // wrong condition
            if (digit > 9)
            {
                throw new ArgumentException("digit[0;9]");
            }
            int[] newArray = new int[numbers.Length];

            int position = 0;
            // the algorithm searches for numbers 
            // containing a digit

            foreach (var el in numbers)
            {
                int number = el;
                while (number > 0)
                {
                    // add number
                    if (number % 10 == digit)
                    {
                        newArray[position] = el;
                        ++position;
                    }
                    number /= 10;
                }
            }
            // remove extra zeros
            Array.Resize(ref newArray, position);
            // remove repetitions
            // sorry for Linq
            // it's so shooort ><
            return newArray.Distinct().ToArray();
        }

        static void Main(string[] args)
        {
        }
    }
}
