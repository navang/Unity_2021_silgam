using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerZoom : MonoBehaviour
{
    public Vector3 pos;
    public GameObject Cam;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) // 누르기 시작할떼 현재위치 가져옴
        {
            pos = transform.position;
        }
        if (Input.GetKey(KeyCode.I)) // 업뎃! 
        {
            pos = Vector3.MoveTowards(Cam.transform.position, pos + new Vector3(0,0,3), 1f * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.I))//
        {
            Cam.transform.position = pos;

        }

    }
}
