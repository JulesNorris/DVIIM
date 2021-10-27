using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoints : MonoBehaviour
{

    public GameObject spawn;
    public GameObject jugador;


    void OnTriggerEnter2D(Collider2D other)
    {
        jugador.transform.position = spawn.transform.position;
        //  Lerp (jugador, objetivoSpawn, 0.05); )
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
