public class Solution {
    public int solution(int n) {
        int answer = n-1;
        bool[] arr = new bool[n+1];
        for(int i=2; i*i <= n; i++)
        {
            if(arr[i] == true) 
            {
                continue;
            }
            for(int j = i*i; j <= n ; j+=i)
            {
                if(arr[j] == true) 
                {
                    continue;
                }
                arr[j] = true;
                answer--;
            }
        }
        
        return answer;
    }
    
   
}