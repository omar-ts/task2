using System.Globalization;
using System.Numerics;
using System.Transactions;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1,2,3,4,5,6};
            int x;
            int y = 2;
            do
            {
                x = int.Parse(Console.ReadLine());
                if (nums.Contains(x))
                {
                    Console.WriteLine(nums.IndexOf(x));
                }
                else
                {
                    Console.WriteLine("error");
                }
            } while (y == 2);
        }
    }
}
