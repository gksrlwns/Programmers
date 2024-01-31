using System;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = new int[2];
        bool isFail = false;
        string temp = words[0];
        int i = 0;
        for (i = 1; i < words.Length; i++)
        {
            if (temp[temp.Length - 1] != words[i][0])
            {
                isFail = true;
                break;
            }
            for (int j = 0; j < i; j++)
            {
                if (words[i] == words[j])
                {
                    isFail = true;
                    break;
                }
            }
            if (isFail == true) break;

            temp = words[i];
        }
        if (isFail == true)
        {
            answer[0] =  i % n + 1;
            answer[1] = i / n + 1;
        }
        else
        {
            answer[0] = 0;
            answer[1] = 0;
        }
        return answer;
    }
}