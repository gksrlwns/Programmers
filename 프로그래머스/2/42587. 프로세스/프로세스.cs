using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 1;
        int[] tempArray = (int[])priorities.Clone();
        Array.Sort(tempArray);
        Array.Reverse(tempArray);
        Queue<List<int>> listQueue = new Queue<List<int>>();
        
        for(int i = 0; i < priorities.Length; i++)
        {
            List<int> list = new List<int>();
            //0 : index , 1 : priorities 값
            list.Add(i);
            list.Add(priorities[i]);
            listQueue.Enqueue(list);
        }
        int count = 0;

        while(listQueue.Count != 0)
        {
            if (listQueue.Peek()[1] != tempArray[count])
            {
                var temp = listQueue.Dequeue();
                listQueue.Enqueue(temp);
            }
            else
            {
                count++;
                var temp = listQueue.Dequeue();
                if (temp[0] == location) break;
                answer++;
            }
        }
        return answer;
    }
}