using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boosts : MonoBehaviour
{
    public GameObject speedUp;
    public GameObject slowDown;
    public static bool isBoosted;

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

    public GameObject baseHairFront;
    public GameObject baseHairBack;

    AudioSource audioSource;
    public AudioClip SpeedUp;
    public AudioClip SlowDown;
    public AudioClip OutfitReset;
    public AudioClip TimeLoss;
    public AudioClip NoBoost;


    void Start()
    {
        speedUp.SetActive(false);
        slowDown.SetActive(false);
        isBoosted = false;
    }

    void Update()
    {
        Debug.Log(isBoosted);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
// Speed Up
        if (collision.tag == "SpeedUp")
        {
            if (isBoosted == false)
            {
                StartSpeedUp();
                audioSource = GetComponent<AudioSource>();
                audioSource.PlayOneShot(SpeedUp); 
            }
        }
// Slow Down
        if(collision.tag == "SlowDown")
        {
            if (isBoosted == false)
            {
                StartSlowDown();
                audioSource = GetComponent<AudioSource>();
                audioSource.PlayOneShot(SlowDown);
            }
        }
// Outfit Reset
        if(collision.tag == "OutfitReset")
        {
            if (isBoosted == false)
            {
                // Reset Outfit
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

                baseHairFront.SetActive(true);
                baseHairBack.SetActive(true);

                // Reset Score
                Player_Score.cloudsScore = 0;
                Player_Score.hair1Score = 0;
                Player_Score.top1Score = 0;
                Player_Score.bottom1Score = 0;
                Player_Score.shoes1Score = 0;
                Player_Score.accessory1Score = 0;

                Player_Score.starsScore = 0;
                Player_Score.hair2Score = 0;
                Player_Score.top2Score = 0;
                Player_Score.bottom2Score = 0;
                Player_Score.shoes2Score = 0;
                Player_Score.accessory2Score = 0;

                Player_Score.bubblesScore = 0;
                Player_Score.hair3Score = 0;
                Player_Score.top3Score = 0;
                Player_Score.bottom3Score = 0;
                Player_Score.shoes3Score = 0;
                Player_Score.accessory3Score = 0;

                audioSource = GetComponent<AudioSource>();
                audioSource.PlayOneShot(OutfitReset);
            }
        }
// Lose Time
        if(collision.tag == "LoseTime")
        {
            if (isBoosted == false)
            {
                LoseTime();
                audioSource = GetComponent<AudioSource>();
                audioSource.PlayOneShot(TimeLoss);
            }
        }
    }

    public void StartSpeedUp()
    {
        isBoosted = true;
        Gravity.newGrav = 0.25f;
        Clothing_Movement.max = 1.5f;
        StartCoroutine(BoostTimer());
        speedUp.SetActive(true);
    }

    public void StartSlowDown()
    {
        isBoosted = true;
        Gravity.newGrav = 0.05f;
        Clothing_Movement.min = 2.0f;
        Clothing_Movement.max = 4.0f;
        StartCoroutine(BoostTimer());
        slowDown.SetActive(true);
    }

    public void LoseTime()
    {
        Player_Score.timerCount = Player_Score.timerCount - 5;
        // Actually subtracts 10 seconds because the player has 2 colliders.
    }

// Return to normal gravity
    IEnumerator BoostTimer()
    {
        print(Time.time);
        yield return new WaitForSeconds(10);
        StopBoost();
    }

    public void StopBoost()
    {
        Gravity.newGrav = 0.1f;
        Clothing_Movement.min = 1.0f;
        Clothing_Movement.max = 5.0f;
        isBoosted = false;
        speedUp.SetActive(false);
        slowDown.SetActive(false);

        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(NoBoost);
    }
}
