using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mute : MonoBehaviour {
    public AudioClip AUDIO;
    AudioSource newAudio;
	// Use this for initialization
    void Awake()
    {
        newAudio.clip=AUDIO;
    }
	void Start () {
        newAudio.Play();
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeScale == 0)
        {
            newAudio.Pause();
        }
	}
}
