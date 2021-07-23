using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRun_01 : MonoBehaviour
{
    public Transform TargetP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //등속이동
        transform.position =
        Vector3.MoveTowards(transform.position, TargetP.position, 0.05f) ;
    }
}
