using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightBehavior : MonoBehaviour
{
public GameObject light1;
public GameObject light2;
public GameObject light3;
public GameObject light4;

public GameObject[] spotlights;

    void Start()
    {
        StartCoroutine(Spotlight());
    }


    IEnumerator Spotlight()
    {
        print(Time.time);
        yield return new WaitForSeconds(1);
        spotlights[Random.Range(0,spotlights.Length)].SetActive(true);
        StartCoroutine(TurnOff());
    }
    IEnumerator TurnOff()
    {
        print(Time.time);
        yield return new WaitForSeconds(2);
        light1.SetActive(false);
        light2.SetActive(false);
        light3.SetActive(false);
        light4.SetActive(false);
        StartCoroutine(Spotlight());
    }
}
