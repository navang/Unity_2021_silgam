using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectControl : MonoBehaviour
{
    public GameObject UI;

    public Text timeO;
    int one = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);
        int sec = ((int)Time.time) ;
        
        //if (Input.anyKey)
        //{
        //    UI.SetActive(false);


        //}
        //if (sec < 10)
        //{
        //    timeO.text = sec.ToString();
        //}
        //else
        //{
        //    timeO.text = "";
        //}
        if (Input.GetMouseButtonDown(0)) 
        {
            Debug.Log("마우스 왼쪽");

        }
        if (Input.GetMouseButtonDown(1)) 
        {
            Debug.Log("마우스 오른쪽");

        }
        if (Input.GetMouseButtonDown(2)) 
        {
            Debug.Log("마우스 휠");

        }

    }
}
