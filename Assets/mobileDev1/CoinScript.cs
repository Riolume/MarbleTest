using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    
    public float rotateSpeed = 3;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 Rotate = new Vector3(0, rotateSpeed, 0);
        transform.eulerAngles += Rotate;
    }

    private void OnCollisionEnter(Collision other)
    {
        MarbleScript ms = other.gameObject.GetComponentInParent<MarbleScript>(); 

        if (ms)
        {
            CounterScript.instance.RemoveCoin(gameObject);
            Destroy(gameObject, 0.1f);
        }
       
    }
}
