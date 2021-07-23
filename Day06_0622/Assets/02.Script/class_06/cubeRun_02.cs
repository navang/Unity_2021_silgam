using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRun_02 : MonoBehaviour
{
    public Transform TargetP;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        // 감속이동

        Vector3 ze = Vector3.zero;
        transform.position =
        Vector3.SmoothDamp(transform.position, TargetP.position
    ,   ref ze, 0.05f);
    }
}
