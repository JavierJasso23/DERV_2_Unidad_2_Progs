using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField]
    GameObject objMirar;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = objMirar.transform.position;
        pos.y = 0;
        transform.LookAt(pos);
    }

}
