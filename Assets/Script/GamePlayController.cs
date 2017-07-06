using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GamePlayController : MonoBehaviour {
    [SerializeField]
    private GameObject pausePanel;
    [SerializeField]
    private GameObject endGamepanel;
    [SerializeField]
    private Button RestartGame;
    private Button ResumeGame;
   
   
  
    public void pauseGame()
    {
        Time.timeScale = 0f;
       
        pausePanel.SetActive(true);
       // ResumeGame.onClick.RemoveAllListeners();
       // ResumeGame.onClick.AddListener(()=>resumeGame());
    }
    public void resumeGame()
    {
        
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }
    public void restartGame()
    {
        RestartGame.onClick.RemoveAllListeners();
        Time.timeScale = 1f;
        SceneManager.LoadScene("Play");

    }
    public void playerDIE()
    {
        Time.timeScale = 0f;
        // pausePanel.SetActive(true);
        endGamepanel.SetActive(true);
        //ResumeGame.onClick.RemoveAllListeners();
       // ResumeGame.onClick.AddListener(() => restartGame());
    }

}
