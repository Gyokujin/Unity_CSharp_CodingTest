using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // ���ڸ� ������ �ְ�, �� ���� �������, ��������, 0���� ����ϴ� ���α׷�

    int num1 = 15;
    int num2 = -48;
    int num3 = 0;

    void Start()
    {
        Solution(num1);
        Solution(num2);
        Solution(num3);
    }

    string Solution(int num)
    {
        string answer = "";

        if (num > 0)
        {
            answer = "���";
        }
        else if (num < 0)
        {
            answer = "����";
        }
        else
        {
            answer = "0";
        }

        Debug.Log(answer);
        return answer;
    }
}