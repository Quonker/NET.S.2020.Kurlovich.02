using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"(first call)time Find nex biigest number({12}): {SNumbers.TimeOfNextBiggerNumber(12)} ticks");
            Console.WriteLine($"time Find nex biigest number({1234321}): {SNumbers.TimeOfNextBiggerNumber(1234321)} ticks");
            Console.WriteLine($"time Find nex biigest number({10}): {SNumbers.TimeOfNextBiggerNumber(10)} ticks");
            Console.WriteLine($"time Find nex biigest number({144}): {SNumbers.TimeOfNextBiggerNumber(144)} ticks");
            Console.WriteLine($"time Find nex biigest number({654321}): {SNumbers.TimeOfNextBiggerNumber(654321)} ticks");
        }
    }
}
