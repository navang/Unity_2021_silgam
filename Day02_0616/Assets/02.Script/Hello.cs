using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SayHello("���� ");
        Eat("����");
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
    // �λ��ϴ� ����� �Լ��� �����
    // �λ��Լ� ����
    void SayHello(string name)
    {
        Debug.Log(name + "�ȳ�");
    }
    void Eat(string name)
    {
        Debug.Log(name + "�� ��Ծ�");
    }
    void Money(int won)
    {
        Debug.Log(won + "�� ����");
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
            Debug.Log("0. �λ�");

        }
        else if ( n == 1)
        {
            Debug.Log("1. �߰�");

        }
        else if( n == 2)
        {
            Debug.Log("2. ����");

        }
        else
        {
            Debug.Log("error < not enable number >");

        }
    }
}
