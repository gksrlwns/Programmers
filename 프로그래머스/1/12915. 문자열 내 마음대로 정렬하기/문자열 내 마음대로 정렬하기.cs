using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string[] solution(string[] strings, int n){
    string[] answer = new string[strings.Length];
    Dictionary<char, List<string>> dic = new Dictionary<char, List<string>>();
    
    foreach(var str in strings)
    {
        if (dic.ContainsKey(str[n]))
        {
            dic[str[n]].Add(str);
        }
        else
        {
            dic[str[n]] = new List<string>() { str };
        }
    }
    List<char> list = new List<char>();
    list = dic.Keys.ToList();
    list.Sort();
    List<string> strList = new List<string>();
    foreach(var value in list)
    {
        if (dic[value].Count >= 1)
        {
            dic[value].Sort();
            foreach (var str in dic[value])
            {
                strList.Add(str);
            }
        }
        else
        {
            strList.Add(dic[value][0]);
        }
    }
    
    answer = strList.ToArray();
    return answer;
}
}