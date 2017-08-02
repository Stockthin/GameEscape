using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour {
    public AudioClip backGroundAudio;
    AudioSource audioManager;
    Slider volSlider;

    void Awake()
    {
        audioManager = GetComponent<AudioSource>();
    }

	// Use this for initialization
	void Start () {

        audioManager.clip = backGroundAudio;
        audioManager.Play();

    }
    void playAudio()
    {
        //audioManager.clip = backGroundAudio;
        audioManager.Play();
    }
   public void stopAudio()
    {
        //audioManager.clip = backGroundAudio;
        audioManager.Stop();
    }
    void PauseAudio()
    {
        audioManager.Pause();
    }
    void resumeAudio()
    {
        audioManager.UnPause();
    }
    public void AddVol()
    {
        audioManager.volume +=(float) 0.15;

    }
    public void decreVol()
    {
        audioManager.volume -=(float) 0.15;
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
