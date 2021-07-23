using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteractive : MonoBehaviour
{
    public GameObject CubeFirst;
    public GameObject CubeSecond;
    public AudioSource WindAudio;
    public Material cubeColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    //private void OnMouseDown()
    //{
    //    Debug.Log("클릭");
    //}
    //private void OnMouseEnter()
    //{

    //    Debug.Log("들어감");
    //}

    //private void OnMouseExit()
    //{
    //    Debug.Log("나감");
    //}
    //private void OnMouseOver()
    //{
    //    Debug.Log("over");
    //}
    //private void OnMouseDrag()
    //{
    //    Debug.Log("drag");
    //}
    //private void OnMouseUp()
    //{
    //    Debug.Log("up");
    //}
    // Update is called once per frame
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        
        CubeFirst.SetActive(true);
        CubeSecond.SetActive(true);

       
    }
    private void OnMouseEnter()
    {
        WindAudio.Play();
    }
    private void OnMouseExit()
    {
        WindAudio.Stop();
    }
    private void OnMouseOver()
    {
    
    }
    void Update()
    {
        
    }
}
