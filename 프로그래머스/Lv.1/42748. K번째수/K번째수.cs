using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array, int[,] commands){
    int commandsLength = commands.GetLength(0);
    int[] answer = new int[commandsLength];
    
    for(int i = 0; i < commandsLength; i ++)
    {
        List<int> list = new List<int>();
        for (int j = commands[i,0]; j<= commands[i,1]; j++)
        {
            list.Add(array[j-1]);
        }
        list.Sort();
        answer[i] = list[commands[i, 2] - 1] ;
    }

    return answer;
}
}