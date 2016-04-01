using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Enter_Numbers
{
    class EnterNumbers
    {
        private const int Count = 10;
        private const int StartNum = 1;
        private const int EndNum = 100;
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            while (nums.Count < Count)
            {
                try
                {
                    nums.Add(!nums.Any() ? ReadNumber(StartNum, EndNum) : ReadNumber(nums[nums.Count - 1], EndNum));
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine("Input is not a number");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.Error.WriteLine("The number is out of range");
                }
                catch (OverflowException)
                {
                    Console.Error.WriteLine("Input is not a 32-bit integer");
                }
            }

            Console.WriteLine("Nums:{0}", string.Join(", ", nums));
        }
        private static int ReadNumber(int start, int end)
        {
            Console.Write("Insert a number in the range {0}-{1}: ", start + 1, end - 1);
            int num = int.Parse(Console.ReadLine());

            if (num >= end || num <= start)
            {
                throw new ArgumentOutOfRangeException("The number is out of range");
            }
            return num;
        }
    }
}
