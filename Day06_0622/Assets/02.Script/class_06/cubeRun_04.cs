using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRun_04 : MonoBehaviour
{
    public Transform TargetP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // slerp : ���� ��������, ȣ�� �׸��� �̵� 
        transform.position =
        Vector3.Slerp(transform.position, TargetP.position, 0.05f);
        // �ӵ��� 0~1�̸� ����Ͽ� �ӵ�����
    }
}
