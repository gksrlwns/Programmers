using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        List<int> answerList = new List<int>();
        int[] person1 = new int [] {1,2,3,4,5};
        int[] person2 = new int [] {2,1,2,3,2,4,2,5};
        int[] person3 = new int [] {3,3,1,1,2,2,4,4,5,5};
        
        int[] answerCount = new int[3];
        List<int[]> personList = new List<int[]>();
        personList.Add(person1);
        personList.Add(person2);
        personList.Add(person3);
        for(int i = 0; i < personList.Count; i++)
        {
            answerCount[i] = RightAnswer(answers, personList[i]);
        }
        
        int maxCount = answerCount.Max();
        for(int i = 0; i < answerCount.Length; i++)
        {
             if(maxCount == answerCount[i]) answerList.Add(i+1);
        }
        
        return answerList.ToArray();
    }
    
    static int RightAnswer(int[] answers,int[] person)
    {
        int count = 0;
        for(int i = 0; i < answers.Length; i++)
        {
            if(answers[i] == person[i%person.Length])
            {
                count++;
            }
        }
        return count;
    }
}