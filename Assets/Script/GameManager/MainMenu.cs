using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    public GameObject Loading;
    public Slider slider;
    public Text progressText;
    IEnumerator LoadScENEaSync(string index)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(index);
        Loading.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = progress * 100f + "%";
            yield return null;

        }
    }
    public void PlayGame(string index)
    {
        StartCoroutine(LoadScENEaSync("Play"));
        Time.timeScale = 0f;
    }

    public void Level2(string index)
    {
        StartCoroutine(LoadScENEaSync("level1"));
        //SceneManager.LoadScene("level1");
        Time.timeScale = 0f;
    }
    public void chooseLevel()
    {

        SceneManager.LoadScene("LevelMenu");
    }
}
