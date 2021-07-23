using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;


public class introManager : MonoBehaviour
{
    public VideoPlayer vp;
    // Start is called before the first frame update
    void Start()
    {
        vp.Play();
       
    }


    // Update is called once per frame
    void Update()
    {
        if (!vp.isPlaying && vp.isPrepared)
        {
           nextLoby(); 
            
        }
    }

    public void nextLoby()
    {
        SceneManager.LoadScene("Loby");
    }

}
