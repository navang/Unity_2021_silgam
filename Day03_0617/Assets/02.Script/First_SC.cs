using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First_SC : MonoBehaviour
{
    // Start is called before the first frame update
    int result = 0;
    void Start()
    {
        //int a = 10; int b = 3;
        //float f1 = a + b; Debug.Log(f1);
        //float f2 = a - b; Debug.Log(f2);
        //float f3 = a * b; Debug.Log(f3);
        //float f4 = a / b; Debug.Log(f4);
        //float f5 = a % b; Debug.Log(f5);


        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int sum = arr[1] + arr[5] + arr[8];
        //Debug.Log(sum);


        //string[] arr ={"ö��", "�μ�", "����", "�ȳ�", "�߰�", };
        //string res = arr[2] + " " +arr[4];
        //Debug.Log(res);

        //bool[] isChecks = { true, true, true, true, false, true, false, true, true, true, };
        //for(int i=0; i<isChecks.Length; i++)
        //{
        //    if(isChecks[i] == false)
        //    {
        //        Debug.Log(i+ "��° ����"+ isChecks[i]);
        //    }
        //    else{  }
        //}


        //int n = Random.Range(60, 100);
        //if (n > 90)
        //{ Debug.Log(n + "���� A����Դϴ�");
        //}else if(n > 80)
        //{ Debug.Log(n + "���� B����Դϴ�");
        //}else if(n > 70)
        //{ Debug.Log(n + "���� C����Դϴ�");
        //}else { Debug.Log(n + "���� Ż��"); }

        //int a = Random.Range(0, 10);
        //int b = Random.Range(0, 10);
        //int c = Random.Range(0, 10);
        //int a = 0;
        //int b = 5;
        //int c = 9;
        //int max = 0;

        //if (a < b) { max = b; }
        //if (max < c) { max = c; }
        //else { max = a; }

        //Debug.Log(a+" " + b + " " + c + " " + "�߿� ���� ū ����"+max);

        //bool isHat = false;
        //bool isRing = false;

        //if(isHat || isRing)
        //{
        //    Debug.Log("���");
        //}

        //int m = Random.Range(1, 13);

        //if( m > 2 && m < 6)
        //{
        //    Debug.Log(m + "���� ��");
        //}
        //else if( m > 5 && m < 9)
        //{
        //    Debug.Log(m + "���� ����");
        //}
        //else if( m > 8 && m < 12)
        //{
        //    Debug.Log(m + "���� ����");
        //}
        //else
        //{
        //    Debug.Log(m + "���� �ܿ�");
        //}

        //if( m == 12 || m < 3 )
        //{
        //    Debug.Log(m + "���� �ܿ�");
        //}
        //else if(m < 6 )
        //{
        //    Debug.Log(m + "���� ��");
        //}
        //else if (m < 9 )
        //{
        //    Debug.Log(m + "���� ����");
        //}
        //else if (m < 12 )
        //{
        //    Debug.Log(m + "���� ����");
        //}


        //int a = Random.Range(1, 10);
        //int b = Random.Range(10, 20);

        //int sum = 0;
        //for( int i = 1; i<= 10; i++)
        //{
        //    sum = sum + i;
        //}
        //Debug.Log(sum);
        //for( int i = 0; i<=20; i++)
        //{
        //    if(i >= a && i<=b )
        //    {
        //        Debug.Log(i);
        //    }
        //}

        //int n = Random.Range(2, 10);

        //for (int i=1; i<10; i++)
        //{
        //    Debug.Log(n + " x " + i + "=" + n * i);

        //}

        //string res = "";
        //for(int i= 1; i<11; i++)
        //{
        //    if (i % 3 == 0)
        //    {
        //        res = res + " " + i;
        //    }
        //}
        //Debug.Log(res);

        //int[] arr = { 1, 2, 3, 4, 5, 6, 7,34,2,123,2,4,66,75,44,5,244,32,1123,1,23,23, };

        //int sum = 0;
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if(arr[i]%2 == 0)
        //    {
        //        sum = sum + arr[i];
        //    }
        //}
        //Debug.Log(sum);

        //int sum = 1000;
        //int hol = 0;
        //int[] arr = { 13, 25, 34, 4343, 52, 617, 723, 3234, 21, 123, 2, 4, 66, 75, 44, 5, 244, 32, 1123, 1, 23, 23,12 };

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] % 2 == 1)
        //    {
        //        hol = hol + arr[i];
        //    }
        //}
        //sum = sum - hol;

        //Debug.Log(sum);
        int n = Random.Range(-10, 10);
        Numbot(n);
        pay(100);
    }

    // Update is called once per frame
    void Update()
    {

    }
    //void WakeUp()
    //{
    //    Debug.Log("�Ͼ �����ؾ���");
    //}
    //void Meet(string action)
    //{
    //    string hello = "�� �ȳ�?";
    //    if (action == "�μ�")
    //    {
    //        Debug.Log(action + hello);
    //    }
    //    else if( action == "����")
    //    {
    //        Debug.Log(action + hello);
    //    }
    //    else if( action == "ö��")
    //    {
    //        Debug.Log(action + hello);
    //    }
    //    else
    //    {
    //        Debug.Log("error namecode");
    //        return;
    //    }



    //void Bob(string name)
    //{
    //    string bob = "�� ��?�Ӱ�";
    //    Debug.Log(name + bob);
    //}
    void Numbot(int n)
    {
        if(n %2 == 0)
        {
            Debug.Log(n + "�� ¦�� �Դϴ�");
        }
        else if( n%2 == 1)
        {
            Debug.Log(n + "�� Ȧ�� �Դϴ�");
        }
        else
        {
            Debug.Log(n +"�� 0 �Դϴ�");
        }
    }

    void pay (int money)
    {
        result = result - money;
    }
}
