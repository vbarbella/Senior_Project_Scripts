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

    private Text timerText;

    public static int timerCount;

    public GameObject spawner;

    public GameObject topBar1;
    public GameObject topBar2;
    public GameObject topBar3;
    public GameObject topBar4;
    public GameObject topBar5;

    public GameObject cloudsIcon;
    public GameObject starsIcon;
    public GameObject bubblesIcon;

    public GameObject starBubble;
    public GameObject bubbleCloud;
    public GameObject cloudStar;

    public GameObject timerCircle;
    public GameObject timerCircle2;


    void Start()
    {
        spawner.SetActive(true);
        
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

        timerCount = 100;
        timerCircle.SetActive(true);
        timerCircle2.SetActive(false);

        topBar1.SetActive(false);
        topBar2.SetActive(false);
        topBar3.SetActive(false);
        topBar4.SetActive(false);
        topBar5.SetActive(false);

        cloudsIcon.SetActive(false);
        starsIcon.SetActive(false);
        bubblesIcon.SetActive(false);

        starBubble.SetActive(false);
        cloudStar.SetActive(false);
        bubbleCloud.SetActive(false);

        timerText = GameObject.Find("TimerText").GetComponent<Text>();
        timerText.text = timerCount + " seconds";

        StartCoroutine(TimerCountdown());
    }

    void Update()
    {
        cloudsScore = hair1Score + top1Score + bottom1Score + shoes1Score + accessory1Score;

        starsScore = hair2Score + top2Score + bottom2Score + shoes2Score + accessory2Score;

        bubblesScore = hair3Score + top3Score + bottom3Score + shoes3Score + accessory3Score;

        timerText.text = timerCount + "";
        
        if(timerCount <= 0)
        {
            spawner.SetActive(false);
            timerText.text = "0";
            Application.Quit();
        }

        if(timerCount <= 30)
        {
            timerCircle.SetActive(false);
            timerCircle2.SetActive(true);
        }

// Score is 0
        if (cloudsScore==0)
        {
            if (starsScore==0)
            {
                if (bubblesScore==0)
                {
                    cloudStar.SetActive(false);
                    bubbleCloud.SetActive(false);
                    starBubble.SetActive(false);
                    bubblesIcon.SetActive(false);
                    starsIcon.SetActive(false);
                    cloudsIcon.SetActive(false);
                    topBar1.SetActive(false);
                    topBar2.SetActive(false);
                    topBar3.SetActive(false);
                    topBar4.SetActive(false);
                    topBar5.SetActive(false);
                }
            }
        }

// Clouds highest score
        if(cloudsScore>starsScore)
        {
            if(cloudsScore>bubblesScore)
            {
                cloudsIcon.SetActive(true);
                starsIcon.SetActive(false);
                bubblesIcon.SetActive(false);
                cloudStar.SetActive(false);
                bubbleCloud.SetActive(false);
                starBubble.SetActive(false);

                if(cloudsScore==1)
                {
                    topBar1.SetActive(true);
                    topBar2.SetActive(false);
                    topBar3.SetActive(false);
                    topBar4.SetActive(false);
                    topBar5.SetActive(false);
                    
                }

                if(cloudsScore==2)
                {
                    topBar1.SetActive(true);
                    topBar2.SetActive(true);
                    topBar3.SetActive(false);
                    topBar4.SetActive(false);
                    topBar5.SetActive(false);
                }

                if(cloudsScore==3)
                {
                    topBar1.SetActive(true);
                    topBar2.SetActive(true);
                    topBar3.SetActive(true);
                    topBar4.SetActive(false);
                    topBar5.SetActive(false);
                }

                if(cloudsScore==4)
                {
                    topBar1.SetActive(true);
                    topBar2.SetActive(true);
                    topBar3.SetActive(true);
                    topBar4.SetActive(true);
                    topBar5.SetActive(false);
                }

                if(cloudsScore==5)
                {
                    topBar1.SetActive(true);
                    topBar2.SetActive(true);
                    topBar3.SetActive(true);
                    topBar4.SetActive(true);
                    topBar5.SetActive(true);
                }
            }
        }

// Stars highest score
        if(starsScore>cloudsScore)
        {
            if(starsScore>bubblesScore)
            {
                starsIcon.SetActive(true);
                cloudsIcon.SetActive(false);
                bubblesIcon.SetActive(false);
                cloudStar.SetActive(false);
                bubbleCloud.SetActive(false);
                starBubble.SetActive(false);

                if(starsScore==1)
                {
                    topBar1.SetActive(true);
                    topBar2.SetActive(false);
                    topBar3.SetActive(false);
                    topBar4.SetActive(false);
                    topBar5.SetActive(false);
                    
                }

                if(starsScore==2)
                {
                    topBar1.SetActive(true);
                    topBar2.SetActive(true);
                    topBar3.SetActive(false);
                    topBar4.SetActive(false);
                    topBar5.SetActive(false);
                }

                if(starsScore==3)
                {
                    topBar1.SetActive(true);
                    topBar2.SetActive(true);
                    topBar3.SetActive(true);
                    topBar4.SetActive(false);
                    topBar5.SetActive(false);
                }

                if(starsScore==4)
                {
                    topBar1.SetActive(true);
                    topBar2.SetActive(true);
                    topBar3.SetActive(true);
                    topBar4.SetActive(true);
                    topBar5.SetActive(false);
                }

                if(starsScore==5)
                {
                    topBar1.SetActive(true);
                    topBar2.SetActive(true);
                    topBar3.SetActive(true);
                    topBar4.SetActive(true);
                    topBar5.SetActive(true);
                }
            }
        }

// Bubbles highest score
        if(bubblesScore>cloudsScore)
        {
            if(bubblesScore>starsScore)
            {
                bubblesIcon.SetActive(true);
                starsIcon.SetActive(false);
                cloudsIcon.SetActive(false);
                cloudStar.SetActive(false);
                bubbleCloud.SetActive(false);
                starBubble.SetActive(false);

                if(bubblesScore==1)
                {
                    topBar1.SetActive(true);
                    topBar3.SetActive(false);
                    topBar4.SetActive(false);
                    topBar5.SetActive(false);
                    
                }

                if(bubblesScore==2)
                {
                    topBar1.SetActive(true);
                    topBar2.SetActive(true);
                    topBar3.SetActive(false);
                    topBar4.SetActive(false);
                    topBar5.SetActive(false);
                }

                if(bubblesScore==3)
                {
                    topBar1.SetActive(true);
                    topBar2.SetActive(true);
                    topBar3.SetActive(true);
                    topBar4.SetActive(false);
                    topBar5.SetActive(false);
                }

                if(bubblesScore==4)
                {
                    topBar1.SetActive(true);
                    topBar2.SetActive(true);
                    topBar3.SetActive(true);
                    topBar4.SetActive(true);
                    topBar5.SetActive(false);
                }

                if(bubblesScore==5)
                {
                    topBar1.SetActive(true);
                    topBar2.SetActive(true);
                    topBar3.SetActive(true);
                    topBar4.SetActive(true);
                    topBar5.SetActive(true);
                }
            }
        }

// Clouds = Stars
        if(cloudsScore==starsScore)
        {
            if(cloudsScore>bubblesScore)
            {
            if(cloudsScore>=1)
            {
                cloudStar.SetActive(true);
                bubbleCloud.SetActive(false);
                starBubble.SetActive(false);
                bubblesIcon.SetActive(false);
                starsIcon.SetActive(false);
                cloudsIcon.SetActive(false);
            }

            if(cloudsScore==1)
            {
                topBar1.SetActive(true);
                topBar2.SetActive(false);
                topBar3.SetActive(false);
                topBar4.SetActive(false);
                topBar5.SetActive(false);
                    
            }

            if(cloudsScore==2)
            {
                topBar1.SetActive(true);
                topBar2.SetActive(true);
                topBar3.SetActive(false);
                topBar4.SetActive(false);
                topBar5.SetActive(false);
            }
            }
        }

        // Stars = Bubbles
        if(starsScore==bubblesScore)
        {
            if(starsScore>cloudsScore)
            {
            if(starsScore>=1)
            {
                starBubble.SetActive(true);
                bubbleCloud.SetActive(false);
                cloudStar.SetActive(false);
                bubblesIcon.SetActive(false);
                starsIcon.SetActive(false);
                cloudsIcon.SetActive(false);
            }

            if(starsScore==1)
            {
                topBar1.SetActive(true);
                topBar2.SetActive(false);
                topBar3.SetActive(false);
                topBar4.SetActive(false);
                topBar5.SetActive(false);
                    
            }

            if(starsScore==2)
            {
                topBar1.SetActive(true);
                topBar2.SetActive(true);
                topBar3.SetActive(false);
                topBar4.SetActive(false);
                topBar5.SetActive(false);
            }
            }
        }

        // Bubbles = Clouds
        if(bubblesScore==cloudsScore)
        {
            if(bubblesScore>starsScore)
            {
            if(bubblesScore>=1)
            {
                bubbleCloud.SetActive(true);
                cloudStar.SetActive(false);
                starBubble.SetActive(false);
                bubblesIcon.SetActive(false);
                starsIcon.SetActive(false);
                cloudsIcon.SetActive(false);
            }

            if(bubblesScore==1)
            {
                topBar1.SetActive(true);
                topBar2.SetActive(false);
                topBar3.SetActive(false);
                topBar4.SetActive(false);
                topBar5.SetActive(false);
                    
            }

            if(bubblesScore==2)
            {
                topBar1.SetActive(true);
                topBar2.SetActive(true);
                topBar3.SetActive(false);
                topBar4.SetActive(false);
                topBar5.SetActive(false);
            }
            }
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
