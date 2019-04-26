using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pausePanel;
    public bool isPaused = false;

    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && pausePanel != null)
        {

            isPaused = !isPaused;
            pausePanel.SetActive(isPaused);
        }
        
        //if(isPaused == true)
        //{
        //    pausePanel.SetActive(false);                          //This does the same thing, just longer
        //    isPaused = false;
        //}
        //else
        //{
        //    pausePanel.SetActive(false);
        //    isPaused = false;
        //}
    }
}
