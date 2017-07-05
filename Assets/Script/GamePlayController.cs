using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlayController : MonoBehaviour {
    [SerializeField]
    private GameObject pausePanel;
    [SerializeField]
    private Button ResumeGame;
	// Use this for initialization
    public void pauseGame()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        ResumeGame.onClick.RemoveAllListeners();
        ResumeGame.onClick.AddListener(()=>resumeGame());
    }
    public void resumeGame()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }
    public void restartGame()
    {
        Time.timeScale = 0.5f;
        SceneManager.LoadScene("Play");

    }
    public void playerDIE()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(true);
        ResumeGame.onClick.RemoveAllListeners();
        ResumeGame.onClick.AddListener(() => restartGame());
    }

}
