using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Event_2 : MonoBehaviour
{
    public GameObject CameraFocus;
    public string NewGameObjectName;
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
        //if (gameObject.name != gameObject.name)
        //{
        //    gameObject.name = null;
        //    Debug.Log("������Ʈ���޶�. ���ݸ���ٷ�");
        //    return;
        //}
        //else
        //{
         //   gameObject.name = gameObject.name;
            CameraFocus.transform.position =
            //transform.position;
            Vector3.Lerp(CameraFocus.transform.position, gameObject.transform.position, 5f * Time.deltaTime);

        //}
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
