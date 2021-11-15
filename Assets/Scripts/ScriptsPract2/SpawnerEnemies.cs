using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemies : MonoBehaviour
{
    public GameObject Enemigo;
    public float timeSpawn = 1f;
    int i;
    void Start()
    {
        i = 0;
        StartCoroutine("coroutineSp");
    }

    private IEnumerator coroutineSp()
    {
        WaitForSeconds Wait = new WaitForSeconds(timeSpawn);
        while (true)
        {
            GameObject newEnemy = Instantiate(Enemigo, transform.position, transform.rotation) as GameObject;
            i++;
            newEnemy.name = "Enemigo" + i;

            yield return Wait;
        }
    }
}
