using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Recticle_Control : MonoBehaviour
{
    public Image recticle;
    public Animator animTemp;

    // Start is called before the first frame update
    void Start()
    {
        recticle.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 20))
        {
            recticle.fillAmount += Time.deltaTime * 0.5f ;
            animTemp = hit.transform.GetChild(0).GetChild(1).GetComponent<Animator>();
            animTemp.enabled = true;
            
            if (recticle.fillAmount == 1)
            {
                if (hit.transform.CompareTag("Load_Start"))
                {
                    SceneManager.LoadScene("SC_Game");
                }
                else if (hit.transform.CompareTag("Load_Credit"))
                {
                    SceneManager.LoadScene("SC_Credit");
                }
            }
        }
        
        else
        {
            animTemp.enabled = false;
            recticle.fillAmount = 0;
        }

        Debug.DrawRay(ray.origin, ray.direction * 20f,Color.red ,0.5f) ;
    }
   
}
