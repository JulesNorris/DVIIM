using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compuertas : MonoBehaviour
{

    public GameObject Puerta;
    public GameObject Boton;
    public GameObject botonPresionado;

    void OnTriggerEnter2D(Collider2D other)
    {
        //Puerta.SetActive(false);
        Puerta.transform.Rotate(0.0f, 0.0f, 90.0f, Space.World);
        Boton.SetActive(false);
        //botonPresionado.SetActive(true);


    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
