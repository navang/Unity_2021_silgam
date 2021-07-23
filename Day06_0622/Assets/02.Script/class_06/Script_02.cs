using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Vector3 Vec = new Vector3(1, 2, 3);

        Vec = Vec + new Vector3(5, 5, 5);

        Debug.Log(Vec.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
