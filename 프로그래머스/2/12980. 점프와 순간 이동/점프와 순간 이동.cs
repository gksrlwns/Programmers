using System;

class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        int temp = 1;
        while(temp <= n)
        {
            temp *= 2;
            if(temp > n)
            {
                temp/=2;
                n-= temp;
                answer++;
                temp = 1;
            }
        }

        return answer;
    }
}