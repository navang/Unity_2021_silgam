using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Event_1 : MonoBehaviour
{
    public GameObject CameraFocus;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        //CameraFocus.transform.position =
       //transform.position;
       //Vector3.MoveTowards(CameraFocus.transform.position, gameObject.transform.position, 5f * Time.deltaTime);
    }
    private void OnMouseDrag()
    {
     CameraFocus.transform.position =
                Vector3.MoveTowards(
                CameraFocus.transform.position, // ��밡
                gameObject.transform.position,  // ������ �´�
                10f * Time.deltaTime);          // �ӵ��� 

      
    }
    // Update is called once per frame
    void Update()
    {
       
        
    }
}
