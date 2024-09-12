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
                Console.WriteLine("K - Ascending number");
                Console.WriteLine("J - Descending number");
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
                    int d = 2;
                    do
                    {
                        number = int.Parse(Console.ReadLine());
                        bool isDuplicated = false;
                        for (i = 0; i < nums.Count; i++)
                        {
                            if (number == nums[i])
                            {
                                isDuplicated = true;
                                break;
                            }
                        }
                        if (isDuplicated)
                        {
                            Console.Write("Choose another number do not be dupliacted: ");
                        }
                        else
                        {
                            nums.Add(number);
                            d = 3;
                        }
                    } while (d == 2);     
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
                    int m = 2;
                    Console.Write("Enter number: ");
                    do
                    {
                        int index;
                        find = int.Parse(Console.ReadLine());
                        bool place = false;
                        for (index = 0; index < nums.Count; index++)
                        {
                            if (find == nums[index])
                            {
                                place = true;
                                break;
                            }
                        }
                        if (place)
                        {
                            Console.WriteLine($"Index of {find} is {index}");
                            m = 3;
                        }
                        else
                        {
                            Console.Write("Number doesnot exist , enter another number: ");
                        }
                    } while (m == 2);
                   
                }
                if(x=='k'||x=='K')
                {
                    Console.Write($"[");
                    for(i=0; i<nums.Count;i++)
                    {
                        for(int j=i+1; j<nums.Count;j++)
                        {
                            if (nums[i] > nums[j])
                            {
                                int a = nums[i];
                                nums[i] = nums[j];
                                nums[j] = a;
                            }
                        }
                        Console.Write($" {nums[i]} ");
                    }
                    Console.Write($"]");
                }

                if (x == 'j' || x == 'J')
                {
                    Console.Write($"[");
                    for (i = 0; i < nums.Count; i++)
                    {
                        for (int j = i + 1; j < nums.Count; j++)
                        {
                            if (nums[i] < nums[j])
                            {
                                int a = nums[i];
                                nums[i] = nums[j];
                                nums[j] = a;
                            }
                        }
                        Console.Write($" {nums[i]} ");
                    }
                    Console.Write($"]");
                }
                Console.WriteLine();
            } while (x != 'Q' && x!='q');
        }
    }
}
