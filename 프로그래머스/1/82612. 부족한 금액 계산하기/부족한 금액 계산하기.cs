using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        //
        long sum = 0;
        for(int i = 1; i <= count; i++)
        {
            sum += price * i;
        }
        sum -= money;
        if (sum < 0)
        {
            return 0;
        }
        else
        {
            return sum;
        }
    }
}