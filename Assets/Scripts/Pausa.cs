using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{

    public GameObject canvas;
    bool isPaused;

    void Start()
    {
        canvas.gameObject.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }

            if (!isPaused)
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        canvas.gameObject.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }

    public void ResumeGame()
    {
        canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }
}
