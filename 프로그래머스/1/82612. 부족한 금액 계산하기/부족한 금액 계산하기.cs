using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long allPrice = 0;
        for (int i = 1; i <= count; i++)
        {
            allPrice += price * i;
        }
        if (allPrice - money > 0) return allPrice - money;

        return 0;
    }
}