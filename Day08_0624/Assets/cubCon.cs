using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubCon : MonoBehaviour
{
    public GameObject Obj_game;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    //private void OnMouseOver()
    //{
    //    gameObject.transform.Rotate(new Vector3(30, 30, 30));
    //}
    void Update()
    {
        //transform.rotation =
        //Quaternion.Euler(new Vector3(0, 0, 0));
        if (Input.GetKey(KeyCode.M))
        {
            Obj_game.transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            Obj_game.transform.localScale = new Vector3(0, 0, 0);
            Obj_game.transform.localScale = Vector3.one;
        }
    }
}
