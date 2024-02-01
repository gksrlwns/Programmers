public class Solution {
    public long solution(int n) {
        //1칸씩만 가는 경우
        int answer = 0;
        if(n < 3) answer = n;
        int n1 = 1;
        int n2 = 2;
        for(int i = 3; i <=n; i++)
        {
            answer = n1 + n2;
            if(answer > 123457)
                answer %= 1234567;
            n1 = n2;
            n2 = answer;
            
        }
        return answer;
    }
}