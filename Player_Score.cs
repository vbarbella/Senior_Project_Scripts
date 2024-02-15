using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{
    // Clouds
    public static int cloudsScore;

    public static int hair1Score;
    public static int top1Score;
    public static int bottom1Score;
    public static int shoes1Score;
    public static int accessory1Score;

    // Stars
    public static int starsScore;

    public static int hair2Score;
    public static int top2Score;
    public static int bottom2Score;
    public static int shoes2Score;
    public static int accessory2Score;

    // Bubbles
    public static int bubblesScore;

    public static int hair3Score;
    public static int top3Score;
    public static int bottom3Score;
    public static int shoes3Score;
    public static int accessory3Score;

    private Text score1;
    private Text score2;
    private Text score3;

    private Text timerText;

    public static int timerCount;

    void Start()
    {
        cloudsScore = 0;
        hair1Score = 0;
        top1Score = 0;
        bottom1Score = 0;
        shoes1Score = 0;
        accessory1Score = 0;

        starsScore = 0;
        hair2Score = 0;
        top2Score = 0;
        bottom2Score = 0;
        shoes2Score = 0;
        accessory2Score = 0;

        bubblesScore = 0;
        hair3Score = 0;
        top3Score = 0;
        bottom3Score = 0;
        shoes3Score = 0;
        accessory3Score = 0;

        timerCount = 200;

        score1 = GameObject.Find("Score1").GetComponent<Text>();
        score1.text = cloudsScore + "/5";

        score2 = GameObject.Find("Score2").GetComponent<Text>();
        score2.text = starsScore + "/5";

        score3 = GameObject.Find("Score3").GetComponent<Text>();
        score3.text = bubblesScore + "/5";

        timerText = GameObject.Find("TimerText").GetComponent<Text>();
        timerText.text = timerCount + " seconds";

        StartCoroutine(TimerCountdown());
    }

    void Update()
    {
        score1.text = cloudsScore + "/5";
        cloudsScore = hair1Score + top1Score + bottom1Score + shoes1Score + accessory1Score;

        score2.text = starsScore + "/5";
        starsScore = hair2Score + top2Score + bottom2Score + shoes2Score + accessory2Score;

        score3.text = bubblesScore + "/5";
        bubblesScore = hair3Score + top3Score + bottom3Score + shoes3Score + accessory3Score;

        timerText.text = timerCount + " seconds";
        
        if(timerCount <= 0)
        {
            timerText.text = "0 seconds";
            Application.Quit();
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Clouds Score Tracker
            if (collision.tag == "Hair1")
            {
                hair1Score = 1;

                hair2Score = 0;
                hair3Score = 0;
            }
            
            if (collision.tag == "Top1")
            {
                top1Score = 1;

                top2Score = 0;
                top3Score = 0;
            }

            if (collision.tag == "Bottom1")
            {
                bottom1Score = 1;

                bottom2Score = 0;
                bottom3Score = 0;
            }

            if (collision.tag == "Shoes1")
            {
                shoes1Score = 1;

                shoes2Score = 0;
                shoes3Score = 0;
            }

            if (collision.tag == "Accessory1")
            {
                accessory1Score = 1;

                accessory2Score = 0;
                accessory3Score = 0;
            }

        // Stars Score Tracker
            if (collision.tag == "Hair2")
            {
                hair2Score = 1;

                hair1Score = 0;
                hair3Score = 0;
            }
            
            if (collision.tag == "Top2")
            {
                top2Score = 1;

                top1Score = 0;
                top3Score = 0;
            }

            if (collision.tag == "Bottom2")
            {
                bottom2Score = 1;

                bottom1Score = 0;
                bottom3Score = 0;
            }

            if (collision.tag == "Shoes2")
            {
                shoes2Score = 1;

                shoes1Score = 0;
                shoes3Score = 0;
            }

            if (collision.tag == "Accessory2")
            {
                accessory2Score = 1;

                accessory1Score = 0;
                accessory3Score = 0;
            }

        // Bubbles Score Tracker
            if (collision.tag == "Hair3")
            {
                hair3Score = 1;

                hair1Score = 0;
                hair2Score = 0;
            }
            
            if (collision.tag == "Top3")
            {
                top3Score = 1;

                top1Score = 0;
                top2Score = 0;
            }

            if (collision.tag == "Bottom3")
            {
                bottom3Score = 1;

                bottom1Score = 0;
                bottom2Score = 0;
            }

            if (collision.tag == "Shoes3")
            {
                shoes3Score = 1;

                shoes1Score = 0;
                shoes2Score = 0;
            }

            if (collision.tag == "Accessory3")
            {
                accessory3Score = 1;

                accessory1Score = 0;
                accessory2Score = 0;
            }
    }

// Timer
    IEnumerator TimerCountdown()
    {
        print(Time.time);
        yield return new WaitForSeconds(1);
        timerCount = timerCount - 1;
        Wait();
    }

    public void Wait()
    {
        StartCoroutine (TimerCountdown());
    }
}
