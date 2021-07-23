using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_rotateStop : MonoBehaviour
{
    public Animator anim_01;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void keyboardSpace()
    {
        anim_01.speed=0;
    }
    // Update is called once per frame
    void Update()
    {
       
    }
   
}
