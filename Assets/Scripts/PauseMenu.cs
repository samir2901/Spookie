using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isGamePause = false;
    public GameObject pauseMenuUI;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        //ResumeFunction
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isGamePause = false;
    }

    void Pause()
    {
        //PauseFunction
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isGamePause = true;        
    }

    public void GotoMainMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("Going to Main Menu YO!!!!!");
        SceneManager.LoadScene("MainMenuScene");
    }

    public void QuitGame()
    {
        Debug.Log("Bye Bye Player!!");
        Application.Quit();
    }
}
