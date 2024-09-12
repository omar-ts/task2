namespace exp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [6, 2, 4, 5, 1, 8];
            for(int i =0;i<nums.Length; i++)
            {
                for(int j=i+1; j<nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        int a = nums[i];
                        nums[i] = nums[j];
                        nums[j]= a;
                    }
                }
                Console.WriteLine(nums[i]);
            }
        }
    }
}
