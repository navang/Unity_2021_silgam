using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 2000f;
    private bool isJump = false;

    public GameObject floor3;

   
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position =transform.position + Vector3.back * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + Vector3.left * speed * Time.deltaTime;
        }

        // 키보드 화살표 이동 

        if (Input.GetKeyDown(KeyCode.Space) && isJump == false)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 10f , ForceMode.Impulse);
            isJump = true;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        // 바닥에 충돌하는걸 감지 할것; 
        if(collision.transform.tag == "FLOOR")
        {
            Debug.Log("바닥");
            isJump = false;
        }
        if(collision.transform.tag == "BUTTON") // 3번째 floor를 키는 버튼
        {
            Debug.Log("버튼");
            floor3.SetActive(true); 
        }
       
    }
}
