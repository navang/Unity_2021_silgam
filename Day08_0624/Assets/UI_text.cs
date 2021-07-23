using UnityEngine;
using UnityEngine.UI;

public class UI_text : MonoBehaviour
{
    public Cnt Cnt;
    public Text text;
    public GageController gageCtrl;
    void Start()
    {
       

    }
    private void OnMouseDown()
    {
        Cnt.AddCount();
        Debug.Log(Cnt.count);
        text.text = Cnt.count.ToString();

        gageCtrl.Add();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
