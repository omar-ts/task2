using System.ComponentModel;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            char x;
            int number;
            int sum = 0;
            double mean;
            int i;
            List<int> nums = new List<int>();
            int min;
            int mx = 0;
            int find;
            do
            {
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("N - Display means of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Find a number");
                Console.WriteLine("C - Clear the whole List");
                Console.WriteLine("Q - Quit");
                Console.Write("Enter what do you want from these choices: ");
                x = char.Parse(Console.ReadLine());
                if (x == 'p' || x == 'P')
                {
                    if (nums.Count == 0)
                    {
                        Console.WriteLine("[] - List is empty");
                    }
                    else if (nums.Count != 0)
                    {
                        Console.Write("[ ");
                        for (i = 0; i < nums.Count; i++)
                        {
                            Console.Write($" {nums[i]} ");
                        }
                        Console.WriteLine(" ]");
                    }
                }
                //Add values and not duplicated
                if (x == 'A' || x == 'a')
                {
                    Console.Write("Enter a number: ");
                    number = int.Parse(Console.ReadLine());
                    if(nums.Contains(number))
                    {
                        Console.WriteLine("Cannot add duplicate numbers");
                    }
                    else
                    {
                        nums.Add(number);
                        Console.WriteLine($"{number} is added");
                    }
                }
                if (x == 'm' || x == 'M')
                {
                    for (i = 0; i < nums.Count; i++)
                    {
                        count++;
                        sum += nums[i];
                    }
                    mean = sum / count;
                    Console.WriteLine($"mean: {mean}");
                }


                if (x == 's' || x == 'S')
                {
                    min = nums[0];
                    for (i = 0; i < nums.Count; i++)
                    {
                        if (min > nums[i])
                            min = nums[i];
                    }
                    Console.WriteLine($"min: {min}");
                }



                if (x == 'l' || x == 'L')
                {
                    for (i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] > mx)
                        {
                            mx = nums[i];
                        }
                    }
                    Console.WriteLine($"max: {mx}");
                }
                if (x == 'c' || x=='C')
                {
                    nums.Clear();
                }
                //find index of number you want 
                if(x=='f' || x=='F')
                {
                    Console.Write("Enter number that you want its index: ");
                    find = int.Parse(Console.ReadLine());
                    if(nums.Contains(find))
                    {
                        Console.Write($"index is : {nums.IndexOf(find)}");
                    }
                    else
                    {
                        Console.WriteLine("the number you entered is not in the list");
                        Console.WriteLine("try again");
                    }
                }
                Console.WriteLine();
            } while (x != 'Q' && x!='q');
        }
    }
}
