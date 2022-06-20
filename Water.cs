using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    
    
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            gameObject.GetComponent<BoxCollider2D>().enabled.Equals(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
