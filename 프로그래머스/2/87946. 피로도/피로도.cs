using System;

public class Solution {
    int answer = -1;
    bool[] isArray;
    
    public int solution(int k, int[,] dungeons) {
        isArray = new bool[dungeons.GetLength(0)];
        DFS(k,dungeons,0);
        return answer;
    }
    
    void DFS(int k, int[,] dungeons, int count)
    {
        for(int i = 0; i<dungeons.GetLength(0); i++)
        {
            if(!isArray[i] && dungeons[i,0] <= k)
            {
                isArray[i] = true;
                DFS(k-dungeons[i,1], dungeons, count + 1);
                isArray[i] = false;
            }
        }
        if(answer < count) answer = count;
        if(answer == dungeons.GetLength(0)) return;
        
    }
}