bool ContainsDuplicate(int[] nums)
{
    Dictionary<int, int> quantValores = new Dictionary<int, int>();
    int aux = 0;

    for (int i=0; i<nums.Length; i++)
    {
        aux = nums[i];
        for (int j=i+1; j<nums.Length;j++)
        {
            if (nums[j] == aux)
            {
                return true;
            }
        }
    }
        return false;
}

int[] arr = { 1, 2, 3, 4, 2, 6 };

Console.WriteLine(ContainsDuplicate(arr));