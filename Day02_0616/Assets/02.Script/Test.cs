using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*  Debug.Log("�ȳ��ϼ���");

          int n = 5;
          Debug.Log(n);
          float f = n / 3.0f;
          Debug.Log(f);

        int n = 2;
        n = n + 10;
        Debug.Log(n);
        string s = "";
        s = s + "�ȳ�";
        s = s + "�ϼ���" + 100;
        Debug.Log(s);
          

        //��� 10, �ٳ��� 5 
        int[] box = new int[2];

        box[0] = 20;
        box[1] = 10;
        string s = "���" + box[0] + "��, �ٳ��� " + box[1] + "��";
        Debug.Log(s);

       
        // ����ǥ �迭
        // 90 80 70 
        int[] study = new int[3];
        study[0] = 90;
        study[1] = 80;
        study[2] = 70;
        int res = 0;
        for (int i = 0; i < study.Length; i++)
        {
            res = res + study[i];
        }
        Debug.Log(res);
         
        // ������ �θ�� �л� �ݰ����ϴ�.
        string[] name = new string[4];
        name[0] = "������";
        name[1] = "�θ��";
        name[2] = "�л�";
        name[3] = "�ݰ����ϴ�";

        string res = name[0] + name[3];
        Debug.Log(res);

        
        // ��� �ٳ��� ���ξ��� ���ڿ��迭
        // 3      1     5       �������迭
        //��� 3�� 
        //�ٳ���1��
        //���ξ��� 5��
        string[] f = new string[3];
        int[] n = new int[3];
        string e = "��, ";
        f[0] = "���";         n[0] = 3;
        f[1] = "�ٳ���";       n[1] = 1;
        f[2] = "���ξ���";     n[2] = 5;

        string apple = f[0] + n[0];
        string banana = f[1] + n[1];
        string fineapple = f[2] + n[2];
        Debug.Log(apple + e + banana + e + fineapple + e);
        */
        // �Ǽ��� �迭 5�� 1.1  2.2 3.3 4.4 5.5
        // 6.6 
        // 9.9  �� �Ǵ� �迭�� ã�ƶ� 

        //float[] f = new float[5];
        //f[0] = 1.1f;
        //f[1] = 2.2f;
        //f[2] = 3.3f;
        //f[3] = 4.4f;
        //f[4] = 5.5f;

        //Debug.Log("���� 6.6�� ������ ���� " + f[0] + ", " + f[4]);
        //Debug.Log("���� 6.6�� ������ ���� " + f[2] + ", " + f[2]);
        //Debug.Log("���� 9.9�� ������ ���� " + f[3] + ", " + f[4]);


        //float result = 0.0f;

        //for(int i= 0; i< f.Length; i++)
        //{
        //    for(int j = 0; j< f.Length; j++)
        //    {
        //        result = f[i] + f[j];
        //        if(result == 6.6f)
        //        {
        //            Debug.Log("���� 6.6�� ������ ���� "+ f[i] + "��" + f[j]);
        //        }else if(result == 9.9f)
        //        {
        //            Debug.Log("���� 9.9�� ������ ���� " + f[i] + "��" + f[j]);
        //        }
        //    }
        //}

        //int a = 10; 
        //if( a < 10)
        //{
        //    Debug.Log("10���� �۴�");
        //}
        //else
        //{
        //    Debug.Log("10���� ���ų� ũ��");
        //}
        //string a = "��";
        //int g = 10000;
        //int s = 5000;
        //int b = 1000;
        //if( a == "��") { Debug.Log(g); }
        //else if ( a == "��") { Debug.Log(s); }
        //else if (a == "��") { Debug.Log(b); }
        //else { }


        // ������ ���� = Ȧ�� ���� ¦������ �Ǻ�
        //int i = 33;
        //if (i == 0) { Debug.Log(" i�� 0"); }
        //else if (i % 2 == 0) { Debug.Log("¦��"); }
        //else { Debug.Log("Ȧ��"); }

        /*int n = 3; 
        if ( n >1 && n > 2)
        {

        }

        // ������ ���� ���� , 
        // 
        int i = -3;
        
            if (i < 0 && i % -2 == 0)
            {
            Debug.Log(i + "�� ¦���̸鼭 ����");
            }
            else if(i > 0 && i % 2 == 0)
            {
            Debug.Log(i + "�� ¦���̸鼭 ���");
            }
            else if (i < 0 && i % -2 == 1)
            {
            Debug.Log(i + "�� Ȧ���̸鼭 ����");
            }
            else if (i > 0 && i % 2 == 1)
            {
            Debug.Log(i + "�� Ȧ���̸鼭 ���");
            }

        


        int start = 3; int end = 15;
        int res = 0; 
        for(int i=start; i<=end; i++)
        {
            res = res + i; 
            
        }
        

       
        // ���� �ڸ��� 3,6,9 �̸鼭 ���� �ڸ��� 3,6,9  
        // ���� �ڸ��� 3,6,9 �϶� ���� 
        for ( int i =1; i<=100; i++)
        {
           if (i % 10 == 3 || i % 10 == 6 || i % 10 == 9)
            { Debug.Log(i);
            }else if( i/10 == 3 || i/10 == 6 || i/10 ==9)
            { Debug.Log(i);
        }
    }
        */

        int[] a = new int[10];

        a[0] = 1;
        a[1] = 123;
        a[2] = 122;
        a[3] = 133;
        a[4] = 112;
        a[5] = 114;
        a[6] = 144;
        a[7] = 155;
        a[8] = 166;
        a[9] = 177;
        int res = a[0];
        for (int i = 0; i < a.Length; i++)
        {
            if (res > a[i])
            {
                res = a[i];
            }
        }
        Debug.Log(res);

    }
        // Update is called once per frame
        void Update()
        {

        }
    
}
