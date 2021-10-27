using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camara111111 : MonoBehaviour
{

    public string escena;

    public GameObject obj;
    
    
    
    public void siguienteEscenaa()
    {
        SceneManager.LoadScene(escena);
    }

    public void apareceobj()
    {
        obj.SetActive(true);

    }

    public void desapareceobj()
    {
        obj.SetActive(false);
    }

}
