using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn2 : MonoBehaviour
{
    public GameObject[] spawnObject;
   // public Vector3 spawnValues;
    public float spawnWait;
    public float spawnWait2;
    public float minTime;
    public float maxTime;
    public int startSpawn;
    public int startSpawn2;
    private bool stop;
    private int randSpawn;
    // int randSpawn;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(waitSpawn());
        StartCoroutine(waitSpawn2());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(minTime, maxTime);
        spawnWait2 = Random.Range(minTime, maxTime);
    }
    IEnumerator waitSpawn()
    {
        yield return new WaitForSeconds(startSpawn);
        while (!stop)
        {
            // randSpawn = Random.Range(0, 1);
            Vector3 spawPosition = new Vector3(Random.Range(6, 8), Random.Range(-4, 4), 0);
            
            Instantiate(spawnObject[0], spawPosition, Quaternion.identity);
            

            yield return new WaitForSeconds(spawnWait);

        }
    }
    IEnumerator waitSpawn2()
    {
        yield return new WaitForSeconds(startSpawn2);
        while (!stop)
        {
            Vector3 spawPositon2 = new Vector3(Random.Range(-6, -8), Random.Range(-4, 4), 0);
            Instantiate(spawnObject[1], spawPositon2, Quaternion.identity);
            yield return new WaitForSeconds(spawnWait2);
        }
    }

}
