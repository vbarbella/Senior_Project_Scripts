using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    void Start()
    {
        GetComponent<Animator>().SetBool("Collected", false);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (Player_Score.cloudsScore == 5)
       { 
            if (collision.tag == "Hair1")
            {
                Wink();
            }

            if (collision.tag == "Top1")
            {
                Wink();
            }

            if (collision.tag == "Bottom1")
            {
                Wink();
            }

            if (collision.tag == "Shoes1")
            {
                Wink();
            }

            if (collision.tag == "Accessory1")
            {
                Wink();
            }
        }

        if (Player_Score.starsScore == 5)
        {
            if (collision.tag == "Hair2")
            {
                Wink();
            }

            if (collision.tag == "Top2")
            {
                Wink();
            }

            if (collision.tag == "Bottom2")
            {
                Wink();
            }

            if (collision.tag == "Shoes2")
            {
                Wink();
            }

            if (collision.tag == "Accessory2")
            {
                Wink();
            }
        }

        if (Player_Score.bubblesScore == 5)
        {
            if (collision.tag == "Hair3")
            {
                Wink();
            }

            if (collision.tag == "Top3")
            {
                Wink();
            }

            if (collision.tag == "Bottom3")
            {
                Wink();
            }
            
            if (collision.tag == "Shoes3")
            {
                Wink();
            }

            if (collision.tag == "Accessory3")
            {
                Wink();
            }
        }
    }

    public void Wink()
    {
        GetComponent<Animator>().SetBool("Collected", true);
        StartCoroutine (WinkTime());
    }

    IEnumerator WinkTime()
    {
        print(Time.time);
        yield return new WaitForSeconds(1);
        StopWink();
    }

    public void StopWink()
    {
        GetComponent<Animator>().SetBool("Collected", false);
    }
}
