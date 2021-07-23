using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*  Debug.Log("안녕하세요");

          int n = 5;
          Debug.Log(n);
          float f = n / 3.0f;
          Debug.Log(f);

        int n = 2;
        n = n + 10;
        Debug.Log(n);
        string s = "";
        s = s + "안녕";
        s = s + "하세요" + 100;
        Debug.Log(s);
          

        //사과 10, 바나나 5 
        int[] box = new int[2];

        box[0] = 20;
        box[1] = 10;
        string s = "사과" + box[0] + "개, 바나나 " + box[1] + "개";
        Debug.Log(s);

       
        // 성적표 배열
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
         
        // 선생님 부모님 학생 반갑습니다.
        string[] name = new string[4];
        name[0] = "선생님";
        name[1] = "부모님";
        name[2] = "학생";
        name[3] = "반갑습니다";

        string res = name[0] + name[3];
        Debug.Log(res);

        
        // 사과 바나나 파인애플 문자열배열
        // 3      1     5       정수열배열
        //사과 3개 
        //바나나1개
        //파인애플 5개
        string[] f = new string[3];
        int[] n = new int[3];
        string e = "개, ";
        f[0] = "사과";         n[0] = 3;
        f[1] = "바나나";       n[1] = 1;
        f[2] = "파인애플";     n[2] = 5;

        string apple = f[0] + n[0];
        string banana = f[1] + n[1];
        string fineapple = f[2] + n[2];
        Debug.Log(apple + e + banana + e + fineapple + e);
        */
        // 실수형 배열 5개 1.1  2.2 3.3 4.4 5.5
        // 6.6 
        // 9.9  가 되는 배열을 찾아라 

        //float[] f = new float[5];
        //f[0] = 1.1f;
        //f[1] = 2.2f;
        //f[2] = 3.3f;
        //f[3] = 4.4f;
        //f[4] = 5.5f;

        //Debug.Log("합이 6.6이 나오는 경우는 " + f[0] + ", " + f[4]);
        //Debug.Log("합이 6.6이 나오는 경우는 " + f[2] + ", " + f[2]);
        //Debug.Log("합이 9.9이 나오는 경우는 " + f[3] + ", " + f[4]);


        //float result = 0.0f;

        //for(int i= 0; i< f.Length; i++)
        //{
        //    for(int j = 0; j< f.Length; j++)
        //    {
        //        result = f[i] + f[j];
        //        if(result == 6.6f)
        //        {
        //            Debug.Log("합이 6.6이 나오는 경우는 "+ f[i] + "와" + f[j]);
        //        }else if(result == 9.9f)
        //        {
        //            Debug.Log("합이 9.9이 나오는 경우는 " + f[i] + "와" + f[j]);
        //        }
        //    }
        //}

        //int a = 10; 
        //if( a < 10)
        //{
        //    Debug.Log("10보다 작다");
        //}
        //else
        //{
        //    Debug.Log("10보다 같거나 크다");
        //}
        //string a = "금";
        //int g = 10000;
        //int s = 5000;
        //int b = 1000;
        //if( a == "금") { Debug.Log(g); }
        //else if ( a == "은") { Debug.Log(s); }
        //else if (a == "동") { Debug.Log(b); }
        //else { }


        // 정수형 변수 = 홀수 인지 짝수인지 판별
        //int i = 33;
        //if (i == 0) { Debug.Log(" i는 0"); }
        //else if (i % 2 == 0) { Debug.Log("짝수"); }
        //else { Debug.Log("홀수"); }

        /*int n = 3; 
        if ( n >1 && n > 2)
        {

        }

        // 정수형 변수 선언 , 
        // 
        int i = -3;
        
            if (i < 0 && i % -2 == 0)
            {
            Debug.Log(i + "는 짝수이면서 음수");
            }
            else if(i > 0 && i % 2 == 0)
            {
            Debug.Log(i + "는 짝수이면서 양수");
            }
            else if (i < 0 && i % -2 == 1)
            {
            Debug.Log(i + "는 홀수이면서 음수");
            }
            else if (i > 0 && i % 2 == 1)
            {
            Debug.Log(i + "는 홀수이면서 양수");
            }

        


        int start = 3; int end = 15;
        int res = 0; 
        for(int i=start; i<=end; i++)
        {
            res = res + i; 
            
        }
        

       
        // 일의 자리가 3,6,9 이면서 십의 자리가 3,6,9  
        // 십의 자리가 3,6,9 일때 전부 
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
