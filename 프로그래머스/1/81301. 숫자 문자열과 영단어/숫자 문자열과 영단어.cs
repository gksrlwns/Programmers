using System;

public class Solution {
    public int solution(string s) {
    string answer = null;
    string[] numStringArray = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    string temp = null;
    for(int i = 0; i< s.Length; i++)
    {
        if (char.IsDigit(s[i]))
        {
            answer += s[i];
            continue;
        }
        else
        {
            temp += s[i];
        }
        if (temp.Length >= 3)
        {
            for(int j = 0; j < numStringArray.Length; j++)
            {
                if (numStringArray[j] == temp)
                {
                    answer += j;
                    temp = null;
                    break;
                }
            }
        }
        
    }
    return int.Parse(answer);
}
}