using System;

public class Solution {
    public int solution(int n) {
int answer = 0;
int count = 0;
for (int i = 1; i < 20; i++)
{
    if (Math.Pow(3, i) > n)
    {
        count = i;
        break;
    }
}
int[] array = new int[count];
int index = 0;
while (count > 0)
{
    count--;
    for (int i = 0; i< 2; i++)
    {
        if ((int)Math.Pow(3, count) <= n)
        {
            array[index]++;
            n -= (int)Math.Pow(3, count);
        }
        else
            break;
    }
    
    index++;
}
foreach(int i in array)
{
    Console.Write(i);
}
Console.WriteLine();

Array.Reverse(array);
foreach (int i in array)
{
    Console.Write(i);
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == 0) continue;
    int tempInt = 1;
    for (int j = 0; j < array.Length - i - 1; j++)
    {
        tempInt *= 3;
    }
    answer += array[i] * tempInt;
}

return answer;
    }
}