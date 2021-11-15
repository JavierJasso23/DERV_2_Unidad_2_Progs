using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ZonaDañoSC : MonoBehaviour
{
    public TextMeshProUGUI txt_Vida;
    public TextMeshProUGUI txt_Aviso;
    public TextMeshProUGUI txt_Puntos;
    int points;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        txt_Puntos.text = points.ToString();
        StartCoroutine("puntos");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Enemigo"))
        {
            if (int.Parse(txt_Vida.text) > 0)
            {
                txt_Vida.text = (int.Parse(txt_Vida.text) - 10f).ToString();
                if (int.Parse(txt_Vida.text) == 0)
                {
                    StopCoroutine("puntos");
                    txt_Vida.text = "0";
                    txt_Aviso.text = "GAME OVER";
                    stopSpawn();
                }
            }
            Destroy(other.gameObject);
        }
    }

    private IEnumerator puntos()
    {
        WaitForSeconds Wait = new WaitForSeconds(1f);

        while (true)
        {
            points++;
            txt_Puntos.text = points.ToString();

            yield return Wait;
        }
    }

    void stopSpawn()
    {
        Destroy(GameObject.Find("EstructuraSp"));
    }

}
