using System;

class Solution 
{
    public int solution(int n) 
   {
        int answer = 0;
        string str = Convert.ToString(n,2);
        int count = str.Replace("0","").Length;
        int nextCount = 0;
        while(count != nextCount)
        {
            n++;
            string temp = Convert.ToString(n,2);
            nextCount = temp.Replace("0","").Length;
        }
        answer = n;
        
        return answer;
    }
}