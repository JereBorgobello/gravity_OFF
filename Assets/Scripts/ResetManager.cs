using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetManager : MonoBehaviour
{

    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            print(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

