using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cambioDeespaciooSpawn : MonoBehaviour
{
    public GameObject targetspawn;
    
    public GameObject jugador;

    void OnTriggerEnter2D(Collider2D other)
    {
        
        
        
        
        jugador.transform.position = targetspawn.transform.position;

       

    }
    
    
  
}
