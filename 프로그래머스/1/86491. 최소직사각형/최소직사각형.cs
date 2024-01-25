using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int arrayLength = sizes.GetLength(0);
        int[] maxSizeArray = new int[2];
        for(int i = 0; i < arrayLength; i++)
        {
            int width = 0;
            int height = 0;

            width = sizes[i, 0] >= sizes[i, 1] ? sizes[i,0] :  sizes[i,1];
            height = sizes[i, 0] <= sizes[i, 1] ? sizes[i, 0] : sizes[i, 1];
            if (maxSizeArray[0] <= width)
            {
                maxSizeArray[0] = width;
            }
            if (maxSizeArray[1] <= height)
            {
                maxSizeArray[1] = height;
            }
        }
        answer = maxSizeArray[0] * maxSizeArray[1];

        return answer;
    }
}