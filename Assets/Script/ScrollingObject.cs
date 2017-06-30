using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {
    public static ScrollingObject current;

    public GameObject pooledObject;
    public int PoolerAmount = 20;
    public bool willGrow = true;
    public List<GameObject> pooledObjects;
    void Awake()
    {
        current = this;
    }


	// Use this for initialization
	void Start () {
        pooledObjects = new List<GameObject>();
        for(int i =0; i < PoolerAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
        
		
	}
    public GameObject GetPoolerGameObject()
    {
        for(int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        if (willGrow)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            pooledObjects.Add(obj);
            return obj;
        }
        return null;
    }
}
