using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class adminescenas : MonoBehaviour
{
    
    public string CargaEscena;
    public GameObject dialogo1;
    public GameObject dialogo2;



    public void cambiarEs()
    {
        SceneManager.LoadScene(CargaEscena);
    }


    public void dialogo1prendido()
    {
        dialogo1.SetActive(true);
    }

    public void dialogo2prendido()
    {
        dialogo2.SetActive(true);
    }


}
