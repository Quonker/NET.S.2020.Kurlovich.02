using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Program
    {
        /// <summary>
        /// method for calculating the root of the nth
        /// the degree(n∈N) of the number(a∈R) 
        /// by the Newton method with a given accuracy.
        /// </summary>
        /// <param name="number"> number under the root </param>
        /// <param name="degree"> root degree </param>
        /// <param name="eps"> algorithm accuracy </param>
        /// <returns> expression result </returns>
        public static double FindNthRoot(double number, int degree, double eps)
        {
            // exceptions to the rules
            if (number == 1)
            {
                return 1;
            }
            else if (degree == 1)
            {
                return number;
            }
            else if (degree < 0)
            {
                number = 1 / number;
            }
            else if(eps <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            // initial value
            // if number < 1, number = 1.
            // value 1 speeds up the algorithm
            double root = number > 1 ? number / degree : 1;
            double rTemp = number;

            // Newton's method
            while (Math.Abs(root - rTemp) >= eps)
            {
                rTemp = number;
                for (int i = 1; i < degree; ++i)
                {
                    rTemp /= root;
                }
                root = 0.5 * (rTemp + root);
            }
            return root;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
