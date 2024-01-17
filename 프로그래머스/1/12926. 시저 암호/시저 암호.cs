public class Solution {
    public string solution(string s, int n) {
    string answer = "";
    char[] chars = s.ToCharArray();
    
    foreach (char ch in chars)
    {
        if (ch == ' ')
        {
            answer += ch; continue;
        }
        if (n >= 26) while (n > 26) n -= 26;
        int temp = ch;
        if(ch <= 90)
        {
            temp += n;
            if(temp > 90)
            {
                temp -= 26;
            }
        }
        else
        {
            temp += n;
            if(temp > 122)
            {
                temp -= 26;
            }
        }
        answer += (char)temp;
    }
    answer = new string(answer);
    return answer;
}
}