using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        foreach (int i in tangerine)
        {
            if (dic.ContainsKey(i))
            {
                dic[i]++;
            }
            else
            {
                dic[i] = 1;
            }
        }
        var list = dic.OrderByDescending(x => x.Value).ToList();
        foreach(var i in list)
        {
            if (k <= 0) break;
            answer++;
            k -= i.Value;
        }
        return answer;
    }
}