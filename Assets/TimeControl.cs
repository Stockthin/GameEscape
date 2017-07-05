using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
    private Slider timeSlider;
    private GameObject player;
    public float time;
    public float timeBurn;
    public float timeLeft = 1f;
    void Awake()
    {
        GetPrefereces();
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!player)
        {
            return;
        }
        if (time > 0)
        {
            time -= timeBurn * Time.deltaTime * timeLeft;
            timeSlider.value = time;
        }
        else
        {
            Destroy(player);
        }
    }
    void GetPrefereces()
    {
        player = GameObject.Find("Player");
        timeSlider = GameObject.Find("Time").GetComponent<Slider>();
        timeSlider.minValue = 0;
        timeSlider.maxValue = time;
        timeSlider.value = timeSlider.maxValue;
    }
}
