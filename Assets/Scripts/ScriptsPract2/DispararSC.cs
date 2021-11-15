using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararSC : MonoBehaviour
{
    [SerializeField]
    GameObject posSpawner;
    [SerializeField]
    GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject bull = Instantiate(bullet, posSpawner.transform.position,
                posSpawner.transform.rotation);

            Destroy(bull, 5);

        }
    }
}
