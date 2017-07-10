using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
       
    
        SceneManager.LoadScene("Play");
        Time.timeScale = 0f;
    }
    public void Level2()
    {
        SceneManager.LoadScene("level1");
        Time.timeScale = 0f;
    }
    public void chooseLevel()
    {

        SceneManager.LoadScene("LevelMenu");
    }
}
