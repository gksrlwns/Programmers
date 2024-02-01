using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] arr) {
        int answer = 1;
        Array.Sort(arr);
        int length = arr.Length - 1;

        int a = arr[length];
        int gcd = 1;
        while (length > 0)
        {
            length--;
            int b = arr[length];
            int i = a;
            int j = b;

            while (true)
            {
                if (i % j == 0)
                {
                    gcd = j;
                    break;
                }
                else
                {
                    gcd = j;
                    j = i % gcd;
                    i = gcd;
                }
            }
            Console.Write($"{a} 와 {b} 의 최대공약수 {gcd},");
            a = a * b / gcd;
            answer = a;
        }
        return answer;
    }
}