using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogo_SO : MonoBehaviour
{
    [SerializeField]
    Dialogo dialogo;

    public int indexActual;


    public GameObject contenedorImagen;
    public Image image;

    [SerializeField]
    public GameObject contenedorDialogo;

    [SerializeField]
    public TextMeshProUGUI texto;

    [SerializeField]
    Sprite imgDefecto;

    private void Awake()
    {
        contenedorImagen = GameObject.Find("Contenedor");
        image = contenedorImagen.GetComponentInChildren<Image>();
    }

    // Start is called before the first frame update
    void Start()
    {
        contenedorDialogo.SetActive(false);
        indexActual = -1;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(dialogo.getCantidadMensajes());

        if (Input.GetKeyDown(KeyCode.F)) //atras
        {
            contenedorDialogo.SetActive(true);
            if (indexActual > 0)
            {
                indexActual--;
                image.sprite = dialogo.getDatosPersonaje(indexActual).personaje.imagen;  //la forma más correcta es esta
                //image.sprite = dialogo.mensaje[indexActual].personaje.imagen;
                texto.text = dialogo.getDatosPersonaje(indexActual).dialogo;
            }
            else {
                    //de momento, no se hace nada
            }
        }

        if (Input.GetKeyDown(KeyCode.G)) //adelante
        {
            contenedorDialogo.SetActive(true);
            if (indexActual < dialogo.getCantidadMensajes()-1)
            {
                indexActual++;
                image.sprite = dialogo.getDatosPersonaje(indexActual).personaje.imagen;
                texto.text = dialogo.getDatosPersonaje(indexActual).dialogo;

                texto.richText = true;
                texto.maxVisibleCharacters = 0;
                StopAllCoroutines();
                StartCoroutine("mostrarTexto");
            }
            else {
                //de momento, no se hace nada
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            contenedorDialogo.SetActive(false);
            indexActual = -1;
            texto.text =  "Sin Texto";
            image.sprite = imgDefecto;
        }

    }
    //Tarea para 19 octubre : 1 . detener corrutina una vez que termina su objetivo
    //                       2 . asegurarse de no poder mostrar un mensaje hasta que el anterior   
    //                           haya sido mostrado completamente
    IEnumerator mostrarTexto()
    {
        while (true)
        {
            float largo = texto.text.Length;
            if (texto.maxVisibleCharacters < largo)
            {
                texto.maxVisibleCharacters += 1;
            }
            else {
                StopCoroutine("mostrarTexto");
            }
            Debug.Log("Ejecucíón Corrutina");
            yield return new WaitForSeconds(.05f);
        }
    }


}
