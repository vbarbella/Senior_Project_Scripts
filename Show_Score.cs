using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Score : MonoBehaviour
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

    void Update()
    {
        // Clouds
        if (Player_Score.hair1Score >= 1)
        {
            baseHairFront.SetActive(false);
            baseHairBack.SetActive(false);
            hair1.SetActive(true);
        }

        if (Player_Score.top1Score >= 1)
        {
            top1.SetActive(true);
        }

        if (Player_Score.bottom1Score >= 1)
        {
            bottom1.SetActive(true);
        }

        if (Player_Score.shoes1Score >= 1)
        {
            shoes1.SetActive(true);
        }

        if (Player_Score.accessory1Score >= 1)
        {
            accessory1.SetActive(true);
        }

        // Stars
        if (Player_Score.hair2Score >= 1)
        {
            baseHairFront.SetActive(false);
            baseHairBack.SetActive(false);
            hair2.SetActive(true);
        }

        if (Player_Score.top2Score >= 1)
        {
            top2.SetActive(true);
        }

        if (Player_Score.bottom2Score >= 1)
        {
            bottom2.SetActive(true);
        }

        if (Player_Score.shoes2Score >= 1)
        {
            shoes2.SetActive(true);
        }

        if (Player_Score.accessory2Score >= 1)
        {
            accessory2.SetActive(true);
        }

        // Bubbles
        if (Player_Score.hair3Score >= 1)
        {
            baseHairFront.SetActive(false);
            baseHairBack.SetActive(false);
            hair3.SetActive(true);
        }

        if (Player_Score.top3Score >= 1)
        {
            top3.SetActive(true);
        }

        if (Player_Score.bottom3Score >= 1)
        {
            bottom3.SetActive(true);
        }

        if (Player_Score.shoes3Score >= 1)
        {
            shoes3.SetActive(true);
        }

        if (Player_Score.accessory3Score >= 1)
        {
            accessory3.SetActive(true);
        }
    }
}
