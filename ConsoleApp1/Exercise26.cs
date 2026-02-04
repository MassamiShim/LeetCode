using System;

namespace ConsoleApp1;

public class Exercise26
{
    public int RemoveDuplicates(int[] nums)
    {
        int result = 0;
        int duplicate = 0;

        List<int> list = new List<int>(nums);

        for (int i = 0; i < list.Count-1;)
        {
            if (list[i] == list[i + 1])
            {
                duplicate++;
                list.Remove(i + 1);
            }
            else
                i++;
        }

        result = list.Count;

        for (int i = 0; i < duplicate; i++)
        {
            list.Add(-1);
        }

        nums = list.ToArray();
        return result;
    }

    public int Run(int[] nums)
    {
        int a = RemoveDuplicates(nums);

        return a;
    }
}
