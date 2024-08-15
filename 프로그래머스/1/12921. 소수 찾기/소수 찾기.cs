public class Solution {
    public int solution(int n) {
        int answer = 0;
        bool[] isBools = new bool[n+1];
        
        for(int i = 2; i <= n; i++)
        {
            if(isBools[i] == false)
            {
                answer ++;
                for(int j = i * 2 ; j > 1 && j <= n; j+= i)
                {
                    isBools[j] = true;
                }
            }
        }
        return answer;
    }
    
   
}