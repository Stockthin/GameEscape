using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public GameObject spawnObject;
    public Vector3 spawnValues;
    public float spawnWait;
    public float minTime;
    public float maxTime;
    public int startSpawn;
    private bool stop;
   // int randSpawn;

	// Use this for initialization
	void Start () {
        StartCoroutine(waitSpawn());
	}
	
	// Update is called once per frame
	void Update () {
        spawnWait = Random.Range(minTime, maxTime);
	}
    IEnumerator waitSpawn()
    {
        yield return new WaitForSeconds(startSpawn);
        while (!stop)
        {
           // randSpawn = Random.Range(0, 1);
            Vector3 spawPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), 0);
            Instantiate(spawnObject, spawPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnWait);
            
        }
    }
  
}
