using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public bool isTitleScreen;
    public GameObject pausePanel;
    public GameObject inGamePanel;
    //public bool isPaused = false;
    public GameManager GM;
    

    [Header("In Game UI")]
    public TextMeshProUGUI timerText;
    public Image healthBar;

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
        //if (Input.GetKeyDown(KeyCode.Escape) && pausePanel != null)
        //{
        //    isPaused = !isPaused;
        //    pausePanel.SetActive(isPaused);
        //    inGamePanel.SetActive(!isPaused);
        //}
        if (!isTitleScreen)
        {
            timerText.text = GM.timer.ToString("F2");

            healthBar.fillAmount = GM.health / 100f;
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

    public void Pause(bool pause)
    {
        if (pausePanel != null)
        {

            pausePanel.SetActive(pause);
            inGamePanel.SetActive(!pause);
        }
    }
}
