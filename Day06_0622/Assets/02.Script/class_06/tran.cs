using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tran : MonoBehaviour
    
{
    public Transform TargetCube;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = transform.position + new Vector3(10, 0, 0);
        ////transform.rotation = Quaternion.Euler(new Vector3(0, 0, 80)); //각도를 정해줌
        //transform.Rotate(0, 0, 80);

     
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 dir = new Vector3(0, 2, 0); //방향
        //float speed = 3.0f; //스피드

        //this.transform.position += dir * speed * Time.deltaTime;
        Vector3 ze =  Vector3.zero;
        //n.x = n.x - 1;
        //transform.position =
        //Vector3.MoveTowards(transform.position, n, 0.08f);
        //transform.position =
        //Vector3.Lerp(transform.position, TargetCube.position, 0.5f * Time.deltaTime);
        transform.position =
    Vector3.SmoothDamp(transform.position, TargetCube.position , ref ze, 0.5f * Time.deltaTime);
    }
}
