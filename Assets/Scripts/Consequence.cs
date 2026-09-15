using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using System.Collections.Concurrent;


public class Consequence : MonoBehaviour
{
    List<GameObject> baskets = new List<GameObject>();
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        baskets.Add(b1);
        baskets.Add(b2);
        baskets.Add(b3);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.Equals("Apple") && baskets.IndexOf(b3) != -1){
            GameObject currentB = baskets[0];
            Destroy(currentB);
            baskets.RemoveAt(0);
            
        }
    }
}
