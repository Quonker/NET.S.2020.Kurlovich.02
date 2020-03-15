using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    public static class SNumbers
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// the method takes a Int32 and returns the nearest largest Int32,
        /// consisting of digits of the original number,
        /// and -1 if there is no such number exist.
        /// </summary>
        /// <param name="number">number for changing</param>
        /// <returns>the nearest largest Int32 or -1, if number doesn't exist</returns>

        public static int FindNextBiggerNumber(int number)
        {
            // the algorithm does not work with negative values
            if (number < 0)
            {
                return -1;
            }
            bool IsNumberExist = false;

            // the algorithm permutes the digits of a number,
            // so an array of Char is used

            char[] numberCA = number.ToString().ToCharArray();

            for (int i = numberCA.Length - 1; i > 0; --i)
            {
                // if the high order is less than the lower low order,
                // they are swapped
                if (numberCA[i] > numberCA[i - 1])
                {
                    // swap ><
                    Swap(ref numberCA[i], ref numberCA[i - 1]);

                    // After the permutation,
                    // the algorithm sorts the remainder of the number.
                    // It turns out the next larger number
                    char[] sortBlock = new char[numberCA.Length - i];

                    // sort
                    Array.Copy(numberCA, i, sortBlock, 0, numberCA.Length - i);
                    Array.Sort(sortBlock);
                    Array.Copy(sortBlock, 0, numberCA, i, numberCA.Length - i);

                    //char[] -> string -> int
                    number = int.Parse(new string(numberCA));
                    IsNumberExist = true;

                    break;
                }
            }
            return IsNumberExist ? number : -1;
        }

        /// <summary>
        /// method for finding time(ticks) to search for a FindNextBiggerNumber
        /// the first use is not correct,
        /// therefore it is recommended that 
        /// the first start of the method be made test
        /// </summary>
        /// <param name="number"></param>
        /// <returns>number finding time(ticks)</returns>

        public static long TimeOfNextBiggerNumber(int number)
        {
            var sw = new Stopwatch();
            sw.Start();
            long startTime = DateTime.Now.Ticks;
            FindNextBiggerNumber(number);

            return sw.ElapsedTicks;
        }


        //  updated at intervals(which is not every tick.
        // We cannot use datetime to calculate ticks
  
        //public static long TimeOfNextBiggerNumber(int number)
        //{
        //    long startTime = DateTime.Now.Ticks;
        //    FindNextBiggerNumber(number);
        //    return  DateTime.Now.Ticks - startTime;
        //}

    }
}
