using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CounterScript : MonoBehaviour
{
    public static CounterScript instance;

    public GameObject coinPrefab;

    public List<GameObject> Coinlist;

    


    private void Awake()
    {
        instance = this;
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEmpty()
    {
        Debug.Log("All the coins are gone. 1UP");
        NewCoins();
        NewCoins();
        NewCoins();
    }

    public void RemoveCoin(GameObject coin)
    {
        
        if (Coinlist.Contains(coin))
        {
            Coinlist.Remove(coin);
            Debug.Log("Coin Removed");
            if (Coinlist.Count <= 0)
            {
                OnEmpty(); 
            }
        }


    }

    
    public void NewCoins()
    {
        float RandX = Random.Range(-9, 9);
        float RandZ = Random.Range(-9, 9);
        GameObject go = Instantiate(coinPrefab, new Vector3(RandX, .66f, RandZ), Quaternion.identity);
        Coinlist.Add(go);
    }
}
