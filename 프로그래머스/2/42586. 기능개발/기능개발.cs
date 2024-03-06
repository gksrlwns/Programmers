using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        List<int> answerList = new List<int>();
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < speeds.Length; i++)
        {
            int count = 0;
            while (progresses[i]<100)
            {
                progresses[i] += speeds[i];
                count++;
            }
            queue.Enqueue(count);
        }

        int queueCount = queue.Count;
        int prev = queue.Dequeue();
        int answerValue = 1;
        for(int i = 0; i< queueCount; i++)
        {
            if (queue.Count == 0)
            {
                answerList.Add(answerValue);
                break;
            }
            int next = queue.Dequeue();
            if (prev >= next) answerValue++;
            else
            {
                answerList.Add(answerValue);
                prev = next;
                answerValue = 1;
                continue;
            }
        }

        return answerList.ToArray();
    }
}