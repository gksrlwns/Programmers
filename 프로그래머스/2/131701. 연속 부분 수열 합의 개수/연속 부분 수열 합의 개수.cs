using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] elements) {
        int answer = 0;
        List<int> list = new List<int>();
        int length = elements.Length;
        int count = 1;
        while(length+1 > count)
        {
            for (int i = 0; i < length; i++)
            {
                int sum = 0;

                for(int j = 0; j < count; j++)
                {
                    if ((i + j) >= length)
                    {
                        sum += elements[i + j - length];
                    }
                    else
                    {
                        sum += elements[i + j];
                    }

                }
                list.Add(sum);
            }
            count++;
        }
        Console.WriteLine();
        list = list.Distinct().ToList();
        answer = list.Count();
        return answer;
    }
}