using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        /// <summary> algorithm for inserting bits from the j-th to the i-th bit one number to another so
        /// that the bits of the second number occupy positions with bit jby bit i 
        /// (bits are numbered from right to left).
        /// </summary>
        /// <param name="numberSource">main number</param>
        /// <param name="numberIn">insert number</param>
        /// <param name="startIndex">start index</param>
        /// <param name="endIndex">end index</param>
        /// <returns>number after add number in</returns>
        public static long InsertNumber(long numberSource, long numberIn, byte startIndex, byte endIndex)
        {
            if(startIndex > endIndex)
            {
                throw new ArgumentException("invalid indexes");
            }
            // segment creation[start; end]
            numberIn = numberIn << startIndex;
            numberIn %= (2 << endIndex);
            // add
            numberSource = numberIn | numberSource;
            return numberSource;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(InsertNumber(15,15,0,0));

            Console.WriteLine(InsertNumber(8, 15, 0, 0));

            Console.WriteLine(InsertNumber(8, 15, 3, 8));
        }
    }
}
