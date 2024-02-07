using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Clothing : MonoBehaviour
{
    public GameObject baseHairFront;
    public GameObject baseHairBack;

    // Clouds
    public GameObject hair1;
    public GameObject top1;
    public GameObject bottom1;
    public GameObject shoes1;
    public GameObject accessory1;

    // Stars
    public GameObject hair2;
    public GameObject top2;
    public GameObject bottom2;
    public GameObject shoes2;
    public GameObject accessory2;

    // Bubbles
    public GameObject hair3;
    public GameObject top3;
    public GameObject bottom3;
    public GameObject shoes3;
    public GameObject accessory3;

    void Start()
    {
        hair1.SetActive(false);
        top1.SetActive(false);
        bottom1.SetActive(false);
        shoes1.SetActive(false);
        accessory1.SetActive(false);

        hair2.SetActive(false);
        top2.SetActive(false);
        bottom2.SetActive(false);
        shoes2.SetActive(false);
        accessory2.SetActive(false);

        hair3.SetActive(false);
        top3.SetActive(false);
        bottom3.SetActive(false);
        shoes3.SetActive(false);
        accessory3.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Clouds
        if (collision.tag == "Hair1")
        {
            hair1.SetActive(true);            

            baseHairFront.SetActive(false);
            baseHairBack.SetActive(false);
            hair2.SetActive(false);
            hair3.SetActive(false);
        }
        
        if (collision.tag == "Top1")
        {
            top1.SetActive(true);            

            top2.SetActive(false);
            top3.SetActive(false);            
        }

        if (collision.tag == "Bottom1")
        {
            bottom1.SetActive(true);            

            bottom2.SetActive(false);
            bottom3.SetActive(false);            
        }

        if (collision.tag == "Shoes1")
        {
            shoes1.SetActive(true);

            shoes2.SetActive(false);
            shoes3.SetActive(false);            
        }

        if (collision.tag == "Accessory1")
        {
            accessory1.SetActive(true);
            
            accessory2.SetActive(false);
            accessory3.SetActive(false);            
        }

        // Stars
        if (collision.tag == "Hair2")
        {
            hair2.SetActive(true);            

            baseHairFront.SetActive(false);
            baseHairBack.SetActive(false);
            hair1.SetActive(false);
            hair3.SetActive(false);            
        }
        
        if (collision.tag == "Top2")
        {
            top2.SetActive(true);
            
            top1.SetActive(false);
            top3.SetActive(false);            
        }

        if (collision.tag == "Bottom2")
        {
            bottom2.SetActive(true);            

            bottom1.SetActive(false);
            bottom3.SetActive(false);            
        }

        if (collision.tag == "Shoes2")
        {
            shoes2.SetActive(true);            

            shoes1.SetActive(false);
            shoes3.SetActive(false);            
        }

        if (collision.tag == "Accessory2")
        {
            accessory2.SetActive(true);            

            accessory1.SetActive(false);
            accessory3.SetActive(false);            
        }

        // Bubbles
        if (collision.tag == "Hair3")
        {
            hair3.SetActive(true);            

            baseHairFront.SetActive(false);
            baseHairBack.SetActive(false);
            hair1.SetActive(false);
            hair2.SetActive(false);            
        }
        
        if (collision.tag == "Top3")
        {
            top3.SetActive(true);            

            top1.SetActive(false);
            top2.SetActive(false);            
        }

        if (collision.tag == "Bottom3")
        {
            bottom3.SetActive(true);            

            bottom1.SetActive(false);
            bottom2.SetActive(false);            
        }

        if (collision.tag == "Shoes3")
        {
            shoes3.SetActive(true);            

            shoes1.SetActive(false);
            shoes2.SetActive(false);            
        }

        if (collision.tag == "Accessory3")
        {
            accessory3.SetActive(true);            

            accessory1.SetActive(false);
            accessory2.SetActive(false);            
        }
    }
}
