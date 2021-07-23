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
        // Lerp : 선형 보간, 직선이동
        transform.position =
        Vector3.Lerp(transform.position, TargetP.position, 0.05f);
        // 속도가 0~1이며 비례하여 속도증가
    }
}
