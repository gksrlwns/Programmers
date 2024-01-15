using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
    int[] answer = new int[] { };
    int[] numSort = new int[numbers.Length];
    List<int> list = new List<int>();
    numSort = numbers.OrderBy(x => x).ToArray();
    for(int i = 0; i < numSort.Length -1; i++)
    {
        for(int j = i + 1; j < numSort.Length; j++)
        {
            list.Add(numSort[i] + numSort[j]);
        }
    }
    
    
    list.Sort();
    answer = list.Distinct().ToArray();
    
    return answer;
}
}