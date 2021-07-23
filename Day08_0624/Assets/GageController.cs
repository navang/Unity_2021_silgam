using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GageController : MonoBehaviour
{
    public Image gage;
    public GameObject restart;
    // Start is called before the first frame update
    void Start()
    {
        gage.fillAmount = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        gage.fillAmount -= 0.1f * Time.deltaTime;

        if(gage.fillAmount < 0.01f)
        {
            restart.SetActive(true);
        }

    }
    public void Add()
    {
        gage.fillAmount += 0.1f;
    }
    
}
