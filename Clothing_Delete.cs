using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothing_Delete : MonoBehaviour
{
    public GameObject thisObject;
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            thisObject.SetActive(false);
        }
        
        if (collision.tag == "Floor")
        {
            thisObject.SetActive(false);
        }
    }
}

