using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Recticle_Control2 : MonoBehaviour
{
    public Image recticle;
    public GameObject Cam;
    public Text time;
    public GameObject replay;
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

        if (Physics.Raycast(ray, out hit, 15))
        {
            if(hit.transform.CompareTag("ARROW") || hit.transform.CompareTag("TREASURE") || hit.transform.CompareTag("HOME"))
            {
                recticle.fillAmount += Time.deltaTime * 0.5f;

                if (recticle.fillAmount == 1 && hit.transform.CompareTag("ARROW"))
                {
                    Camera.main.transform.position = hit.transform.position + new Vector3(0, 1.99f, 0);
                }
                else if (recticle.fillAmount == 1 && hit.transform.CompareTag("TREASURE"))
                {
                    Camera.main.transform.position = hit.transform.position + new Vector3(0, 0, 1);

                    int Tm = ((int)Time.time);
                    time.text = Tm.ToString();
                    hit.transform.GetComponent<BoxCollider>().enabled = false;  // 콜리더 없앰
                    replay.SetActive(true);
                }
                else if(recticle.fillAmount == 1 && hit.transform.CompareTag("HOME"))
                {
                    SceneManager.LoadScene("SC_Menu");
                }

                else
                {
                    Debug.Log("no tagged");
                }
            }
            
            else
            {
                recticle.fillAmount -= Time.deltaTime * 0.5f;
            }
        }
        else
        {
            recticle.fillAmount = 0;
        }
        //              시작점     방향          * 길이    컬러   잔존시간
        Debug.DrawRay(ray.origin, ray.direction * 15f,Color.red ,0.5f) ;
    }
   
}
