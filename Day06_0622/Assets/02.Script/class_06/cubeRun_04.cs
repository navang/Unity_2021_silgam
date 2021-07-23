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
        // slerp : 구면 선형보간, 호를 그리며 이동 
        transform.position =
        Vector3.Slerp(transform.position, TargetP.position, 0.05f);
        // 속도가 0~1이며 비례하여 속도증가
    }
}
