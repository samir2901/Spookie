using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMainMenu : MonoBehaviour
{
    public GameObject mainmenuPanel;
    public GameObject instructionPanel;
    public void GotoGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void OpenInstructionPanel()
    {
        mainmenuPanel.SetActive(false);
        instructionPanel.SetActive(true);
    }
    public void GoBacktoMainMenu()
    {        
        instructionPanel.SetActive(false);
        mainmenuPanel.SetActive(true);
    }
    
    public void quitGame()
    {
        Debug.Log("Quit Game Working :)");
        Application.Quit();
    }
}
