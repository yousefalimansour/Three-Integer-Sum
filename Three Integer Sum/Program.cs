namespace Three_Integer_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            int[] nums1 = { 0,0,0,0 };


            foreach (var item in ThreeSum01(nums))
            {
                foreach(int item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }
        }

        public static List<List<int>> ThreeSum(int[] nums)
        {
            int left=0 , right=nums.Length-1;
            List<List<int>> result = new List<List<int>>();
            Array.Sort(nums);//  -4 , -1 , -1 , 0 , 1 , 2

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                left = i + 1;
                right = nums.Length - 1;
              


                while (left < right)
            {

                if (nums[left] + nums[right]  < 0) left++;

                else if (nums[left] + nums[right] > 0) right--;

                else
                {
                   result.Add( new List<int>() { nums[left],nums[right], });
                    left++;
                    right--;
                }

            }
         }
            return result;
        }
        public static IList<IList<int>> ThreeSum01(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();
            int left = 0, right = 0;
            Array.Sort(nums);//  -4 , -1 , -1 , 0 , 1 , 2

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                left = i + 1;
                right = nums.Length - 1;

                while (left < right)
                {
                    if (nums[i] + nums[left] + nums[right] > 0)
                    {
                        right--;
                    }
                    else if (nums[i] + nums[left] + nums[right] < 0)
                    {
                        left++;
                    }
                    else
                    {
                        res.Add(new List<int> { nums[i], nums[left], nums[right] });
                        left++;
                        while (nums[left] == nums[left - 1] && left < right)
                        {
                            left++;
                        }
                    }
                }
            }
            return res;
        }
    }
}