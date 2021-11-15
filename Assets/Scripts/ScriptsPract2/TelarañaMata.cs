using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelarañaMata : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Enemigo"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
