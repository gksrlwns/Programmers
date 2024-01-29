using System;

public class Solution {
    public int solution(int[] A, int[] B) {
        int answer = 0;
        Array.Sort(A);
        Array.Sort(B);
        foreach(var i in A)
        {
            Console.Write(i);
        }
        int length = A.Length;
        for(int i = 0; i < length; i++)
        {
            answer += A[i] * B[length-i-1];
        }
        
        return answer;
    }
}