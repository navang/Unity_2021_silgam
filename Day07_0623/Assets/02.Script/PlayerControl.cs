using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float xP = 0;
    float zP = 0;

    bool isActiveObject;
    public float speed = 0.5f;
    public AudioSource Audio;
    public GameObject TargetObj;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            xP -= speed;
            Debug.Log("A");
        };
        if (Input.GetKey(KeyCode.D))
        {
            xP += speed;
            Debug.Log("D");
        }
        if (Input.GetKey(KeyCode.W))
        {
            zP += speed;
            Debug.Log("W");
        }
        if (Input.GetKey(KeyCode.S))
        {
            zP -= speed;
            Debug.Log("S");
        }
        // Æ÷Áö¼Ç wasd 
        transform.position = new Vector3(xP, 1 , zP);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SoundP();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SoundStop();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            isActiveObject = false;
            TargetObj.SetActive(isActiveObject);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            isActiveObject = true;
            TargetObj.SetActive(isActiveObject);
        }
    }
    void SoundP()
    {
        Audio.Play();
    }
    void SoundStop()
    {
        Audio.Pause();
    }
}
