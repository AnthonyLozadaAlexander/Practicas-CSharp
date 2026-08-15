namespace LogicaProgramacion;

public class ExLeetCode
{
    public int MissingNumber(int[] nums)
    {
        int n = 0, sumReal = 0, sumExpected = 0, missingNumber = 0;
        n = nums.Length;
        
        foreach(int r in nums)
        {
            sumReal = sumReal + r;
        }

        sumExpected = ((n * (n + 1)) / 2);

        missingNumber = sumExpected - sumReal;
        
        return missingNumber;
    }
}