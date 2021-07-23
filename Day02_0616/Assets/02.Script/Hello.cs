using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SayHello("영수 ");
        Eat("영수");
        Money(500);
        Money(1000);
        Add(100, 200);
        Subtract(100, 200);
        MultipleThree(100, 200, 300);

       // Action(1);

    }

    // Update is called once per frame
    void Update()
        
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Action(0);
        }; if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Action(1);
        }; if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Action(2);
        }
    }
    // 인사하는 기능을 함수로 만들고
    // 인사함수 실행
    void SayHello(string name)
    {
        Debug.Log(name + "안녕");
    }
    void Eat(string name)
    {
        Debug.Log(name + "야 밥먹어");
    }
    void Money(int won)
    {
        Debug.Log(won + "원 있음");
    }
    void Add(int a, int b)
    {
        Debug.Log(a + b);
        
    }
    void Subtract(int a, int b)
    {
        Debug.Log(a - b);

    }
    void MultipleThree(int a, int b, int c)
    {
        Debug.Log(a + b + c);
    }
  
    void Action(int n)
    {
        if( n == 0)
        {
            Debug.Log("0. 인사");

        }
        else if ( n == 1)
        {
            Debug.Log("1. 잘가");

        }
        else if( n == 2)
        {
            Debug.Log("2. 쿨쿨");

        }
        else
        {
            Debug.Log("error < not enable number >");

        }
    }
}
