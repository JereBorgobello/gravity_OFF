using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasScript : MonoBehaviour
{

    public void Jugar()
    {
        SceneManager.LoadScene(2);
    }

    public void Ayuda()
    {
        SceneManager.LoadScene(1);
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Atras()
    {
        SceneManager.LoadScene(0);
    }

}
