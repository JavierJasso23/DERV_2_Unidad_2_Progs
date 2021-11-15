using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt_PJ : MonoBehaviour
{
    GameObject objMirar;

    // Start is called before the first frame update
    void Start()
    {
        objMirar = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(objMirar.transform);
                
        Vector3 pos = objMirar.transform.position;
        pos.y = 0;
        transform.LookAt(pos);
        
    }
}
