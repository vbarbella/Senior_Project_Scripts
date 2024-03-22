using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{

    public GameObject cloudsEffect;
    public GameObject starsEffect;
    public GameObject bubblesEffect;

    AudioSource audioSource;
    public AudioClip Winking;

    void Start()
    {
        GetComponent<Animator>().SetBool("Collected", false);
    }

    void Update()
    {
        if (Player_Score.cloudsScore < 5)
        {
            cloudsEffect.SetActive(false);
        }
        if (Player_Score.starsScore < 5)
        {
            starsEffect.SetActive(false);
        }
        if (Player_Score.bubblesScore < 5)
        {
            bubblesEffect.SetActive(false);
        }

        if (Player_Score.cloudsScore >= 5)
        { 
            cloudsEffect.SetActive(true);
        }
        if (Player_Score.starsScore >= 5)
        { 
            starsEffect.SetActive(true);
        }
        if (Player_Score.bubblesScore >= 5)
        { 
            bubblesEffect.SetActive(true);
        }
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (Player_Score.cloudsScore == 5)
       { 
            //cloudsEffect.SetActive(true);

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
            //starsEffect.SetActive(true);

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
            //bubblesEffect.SetActive(true);

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

        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(Winking);
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
