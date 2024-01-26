using System;
using System.Linq;
public class Solution {
    public string solution(int[] food) {
        string answer = "";
        string temp = "";
        for(int i = 1; i<food.Length; i++)
        {
            if(food[i]/2 >= 1)
            {
                for(int j = 0; j < food[i]/2; j++)
                {
                    string tempI = i.ToString();
                    temp += tempI;
                }
                
            }
        }
        answer += temp;
        answer += '0';
        string reverseTemp = new string(temp.Reverse().ToArray());
        answer += reverseTemp;
        return answer;
    }
}