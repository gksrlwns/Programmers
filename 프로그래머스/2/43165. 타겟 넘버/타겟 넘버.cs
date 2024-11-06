using System;

public class Solution {
    int answer = 0;
    public int solution(int[] numbers, int target) {
        
        DFS(numbers,target,0,0);
        return answer;
    }
    void DFS(int[] array, int target, int index, int sum)
    {
        if(index == array.Length)
        {
            if(sum == target)
            {
                answer++;
            }
        }
        else
        {
            DFS(array,target,index + 1, sum + array[index]);
            DFS(array,target,index + 1, sum - array[index]);
        }
    }
    
    
}