using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButton : MonoBehaviour
{
    bool isClicked= false;
    public GameObject CamStart;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void OnMouseDown()
    {
        isClicked = true; Debug.Log(isClicked);
        // gameObject.SetActive(false); Debug.Log("�����");

    }

    Vector3 zero = new Vector3(0.5f, 0.5f, 0.5f);
    // Update is called once per frame
    void Update()
    {
        Debug.Log("������Ʈ����" + isClicked);
        if (isClicked == true)
        {
            Debug.Log("������Ʈ- �̵���");
            CamStart.transform.position =
        Vector3.MoveTowards(CamStart.transform.position, zero, 0.05f);
        }

        if( CamStart.transform.position.x < zero.x &&
            CamStart.transform.position.y < zero.y &&
            CamStart.transform.position.z < zero.z )
        {
            Debug.Log("������Ʈ��");
            isClicked = false;
        }
        
    }
}
