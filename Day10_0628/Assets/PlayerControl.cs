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

        // Ű���� ȭ��ǥ �̵� 

        if (Input.GetKeyDown(KeyCode.Space) && isJump == false)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 10f , ForceMode.Impulse);
            isJump = true;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        // �ٴڿ� �浹�ϴ°� ���� �Ұ�; 
        if(collision.transform.tag == "FLOOR")
        {
            Debug.Log("�ٴ�");
            isJump = false;
        }
        if(collision.transform.tag == "BUTTON") // 3��° floor�� Ű�� ��ư
        {
            Debug.Log("��ư");
            floor3.SetActive(true); 
        }
       
    }
}
