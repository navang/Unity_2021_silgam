using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRun_03 : MonoBehaviour
{
    public Transform TargetP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Lerp : ���� ����, �����̵�
        transform.position =
        Vector3.Lerp(transform.position, TargetP.position, 0.05f);
        // �ӵ��� 0~1�̸� ����Ͽ� �ӵ�����
    }
}
