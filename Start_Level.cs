using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Level : MonoBehaviour
{

    public GameObject timer;
    public GameObject timerText;
    public GameObject spawn;
    public GameObject textBox;
    public GameObject textBox2;

    public GameObject num1;
    public GameObject num2;
    public GameObject num3;

    public GameObject sky1;
    public GameObject sky2;

    public GameObject grid1;
    public GameObject grid2;

    public GameObject spotlights;

    public GameObject levelMusic1;
    public GameObject levelMusic2;

    public GameObject musicPS;

    void Start()
    {
        timer.SetActive(false);
        spawn.SetActive(false);
        sky1.SetActive(false);
        spotlights.SetActive(false);

        textBox.SetActive(true);
        sky2.SetActive(true);

        Player_Score.timerCount = 101;

        Player_Movement.playerSpeed = 0;
    }

    public void StartLevel()
    {
        textBox.SetActive(false);
        spawn.SetActive(true);

        StartCoroutine(Count1());
    }
    public void CloseTextBox()
    {
        textBox2.SetActive(false);
    }
    public void OpenTextBox()
    {
        textBox2.SetActive(true);
    }

    IEnumerator Count1()
    {
        print(Time.time);
        yield return new WaitForSeconds(0);
        num3.SetActive(true);
        StartCoroutine(Count2());
    }

    IEnumerator Count2()
    {
        print(Time.time);
        yield return new WaitForSeconds(1);
        num2.SetActive(true);
        num3.SetActive(false);

        StartCoroutine(Count3());
    }

    IEnumerator Count3()
    {
        print(Time.time);
        yield return new WaitForSeconds(1);
        num1.SetActive(true);
        num2.SetActive(false);

        StartCoroutine(Count4());
    }

    IEnumerator Count4()
    {
        print(Time.time);
        yield return new WaitForSeconds(1);
        num1.SetActive(false);
        timer.SetActive(true);
        timerText.SetActive(true);
        StartCoroutine(TimerCountdown());
        Player_Score.timerCount = 100;
        Player_Movement.playerSpeed = 8;

        sky1.SetActive(true);
        sky2.SetActive(false);

        grid1.SetActive(false);
        grid2.SetActive(true);

        spotlights.SetActive(true);

        levelMusic1.SetActive(true);
        levelMusic2.SetActive(false);

        musicPS.SetActive(true);
    }

    // Timer
    IEnumerator TimerCountdown()
    {
        print(Time.time);
        yield return new WaitForSeconds(1);
        Player_Score.timerCount = Player_Score.timerCount - 1;
        Wait();
    }

    public void Wait()
    {
        StartCoroutine (TimerCountdown());
    }
}
