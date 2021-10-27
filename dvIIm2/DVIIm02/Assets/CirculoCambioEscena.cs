using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CirculoCambioEscena : MonoBehaviour
{


    public string nombreEscenaCargar;
    public GameObject objeto1;


    
    public void siguienteEscena()
    {

        SceneManager.LoadScene(nombreEscenaCargar);
    }

    public void objeto1Visible()
    {
        objeto1.SetActive(true);
    }
    public void objeto1invisible()
    {
        objeto1.SetActive(false);
    }

}
