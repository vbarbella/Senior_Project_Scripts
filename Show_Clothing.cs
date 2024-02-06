using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Clothing : MonoBehaviour
{
    public GameObject baseHairFront;
    public GameObject baseHairBack;
    public GameObject hair1;
    public GameObject top1;
    public GameObject bottom1;
    public GameObject shoes1;
    public GameObject accessory1;

    void Start()
    {
        hair1.SetActive(false);
        top1.SetActive(false);
        bottom1.SetActive(false);
        shoes1.SetActive(false);
        accessory1.SetActive(false);

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Hair1")
        {
            hair1.SetActive(true);
            baseHairFront.SetActive(false);
            baseHairBack.SetActive(false);
        }
        
        if (collision.tag == "Top1")
        {
            top1.SetActive(true);
        }

        if (collision.tag == "Bottom1")
        {
            bottom1.SetActive(true);
        }

        if (collision.tag == "Shoes1")
        {
            shoes1.SetActive(true);
        }

        if (collision.tag == "Accessory1")
        {
            accessory1.SetActive(true);
        }
    }
}
