using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnTriggerEnter (Collider other)
    {
        
        if(other.gameObject.name != "Player"){
            return;
        }

        Destroy(gameObject);

        GameManager.inst.Increment();

    }


    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
