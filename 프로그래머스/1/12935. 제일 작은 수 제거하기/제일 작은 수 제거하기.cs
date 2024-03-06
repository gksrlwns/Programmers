using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] { };
        List<int> intList = new List<int>();
        if(arr[0]== 10) return answer = new int[1] {-1};
        intList = arr.ToList();
        int i = arr.Min();
        intList.Remove(i);
        answer = intList.ToArray();
        return answer;
    }
}