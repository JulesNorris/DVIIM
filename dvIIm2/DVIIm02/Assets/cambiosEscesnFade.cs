using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiosEscesnFade : MonoBehaviour
{

    public string nombreEscenaCargar;
    
    public void cambioEscena()
    {

        SceneManager.LoadScene(nombreEscenaCargar);
    }
}
