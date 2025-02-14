namespace aspnetcoreapp.test;

public unsafe int SubarraySum(int[] array, int start, int end)  // Sensitive
{
    var sum = 0;

    // Skip array bound checks for extra performance
    fixed (int* firstNumber = array)
    {
        for (int i = start; i < end; i++)
            sum += *(firstNumber + i);
    }

    return sum;
}
