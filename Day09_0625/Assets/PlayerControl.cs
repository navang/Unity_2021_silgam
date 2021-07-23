using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour

{
    public float speed = 5f;
    public Rigidbody RB;
    public GameObject BO;
    public GameObject FollowCam;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RB.AddForce(new Vector3(0, 1, 0) * 10f, ForceMode.Impulse);
        }

        //if (Input.GetMouseButton(0))
        //{

        //    Instantiate(BO,   BO.transform.position + new Vector3(0,-5,0) ,   BO.transform.rotation);	// 생성할때 오브젝트의 회전값 지정
        //}


        FollowCam.transform.position =
            Vector3.Slerp(FollowCam.transform.position, transform.position + new Vector3(0, 0, -5f), 0.5f * speed * Time.deltaTime);


    }
    private void OnCollisionEnter(Collision collision)
    {
        // 콜리전에 처음 부딛힌 오브젝트가 있다 
        // 코인삭제
        if(collision.transform.tag == "Monster")
        {
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionStay(Collision collision)
    {

    }
    private void OnCollisionExit(Collision collision)
    {

    }
}
