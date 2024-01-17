public class Solution
{
    public int[] solution(int[] arr, int divisor)
    {

        int count = 0;
        foreach (int element in arr)
        {
            if (element % divisor == 0)
            {
                count++;
            }
        }

        int[] answer = new int[count];

        count = 0;
        foreach (int element in arr)
        {
            if (element % divisor == 0)
            {
                answer[count] = element;
                count++; //요게
            }
            // 요기있어서 인덱스 OutOfRange 오류남;;
        }

        if (answer.Length > 0)
        {
            for (int i = 0; i < answer.Length; i++)
            {
                for (int j = i; j < answer.Length; j++)
                {
                    if (answer[i] > answer[j])
                    {
                        int temp = answer[i];
                        answer[i] = answer[j];
                        answer[j] = temp;
                    }
                }
            }
        }
        else
        {
            answer = new int[1];
            answer[0] = -1;
        }

        return answer;
    }
}