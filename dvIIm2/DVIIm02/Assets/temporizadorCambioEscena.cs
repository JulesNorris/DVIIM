using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class temporizadorCambioEscena : MonoBehaviour
{

    public string CargarNivel;
    public float segundosEspera;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

        segundosEspera -= Time.deltaTime;

        if (segundosEspera<=0)
        {
            SceneManager.LoadScene(CargarNivel);
        }

        

    }
}
