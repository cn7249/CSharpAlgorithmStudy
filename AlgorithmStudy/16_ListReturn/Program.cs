﻿public class Solution
{
    public long[] solution(int x, int n)
    {
        long[] answer = new long[n];

        for (int i = 0; i < n; i++)
        {
            if(i != 0)
            {
                answer[i] = x + answer[i-1];
            }
            else
            {
                answer[i] = x;
            }
        }
        return answer;
    }
}