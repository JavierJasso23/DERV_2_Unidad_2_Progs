using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack_PJ : MonoBehaviour
{
    GameObject ObjDestino;
    [SerializeField]
    float speed = 10;

    void Start()
    {
        ObjDestino = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {        
        Vector3 origen = transform.position;
        Vector3 destino = ObjDestino.transform.position;
        transform.LookAt(destino);
        transform.position =  Vector3.MoveTowards(origen, destino, speed * Time.deltaTime);
    }
    
}


//destino.x -= 10.0f;
//destino.z -= 10.0f;
//transform.position = Vector3.Lerp(origen, destino, speed * Time.deltaTime);

//Vector3 currentVelocity = new Vector3(0f, 0f, 0f);
//transform.position = Vector3.SmoothDamp(origen, destino,ref currentVelocity, speed * Time.deltaTime);

//float distancia = Vector3.Distance(origen, destino);
//Debug.Log(distancia);
