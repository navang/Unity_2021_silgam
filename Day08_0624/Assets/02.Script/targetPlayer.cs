using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetPlayer : MonoBehaviour
{
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {                                 // new vector(0,0,1πÊ«‚)
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back  * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left  * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            speed++;
           
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            speed--;
            if (speed < 1)
            {
                speed = 1;
            }
        }
       
    }
}
