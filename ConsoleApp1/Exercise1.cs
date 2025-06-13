namespace ConsoleApp1;

public class Exercise1
{
    public int[] TwoSum(int[] nums, int target) {
        for (int j = 0; j < nums.Length; j++)
        {
            for(int k = j + 1; k < nums.Length; k++)
            {
                if(nums[k] + nums[j] == target)
                return[j,k];
            }
        }
    return [0];
    }


    public int[] Run(int[] a, int b)
    {
        // int [] a = { 2,7,11,15};

        int[] c = TwoSum(a, b);

        // Console.WriteLine(string.Join(", ", c));
        return c;
        }
}