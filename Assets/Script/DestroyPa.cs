using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPa : MonoBehaviour {

    
    public float timeLife;
    void OnEnable()
    {
        Invoke("Destroy", timeLife);
       // StartCoroutine(IEDestroy());
    }

     /*IEnumerator IEDestroy()
     {
         yield return new WaitForSeconds(0.1);

         Destroy();
     }*/
    void Destroy()
    {
        //gameObject.SetActive(false);
        Destroy(this.gameObject);
        
    }
    void OnDisable()
    {
        CancelInvoke();
    }
}
