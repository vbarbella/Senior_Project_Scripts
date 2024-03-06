using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothing_Movement : MonoBehaviour
{
    public GameObject[] spawnObjects;
    public static float min = 1;
    public static float max = 5;

    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        print(Time.time);
        yield return new WaitForSeconds(2);
        StartCoroutine(StartGame());
    }
    IEnumerator StartGame()
    {
        print(Time.time);
        yield return new WaitForSeconds(Random.Range(min,max));
        SpawnClothing();
    }

    public void SpawnClothing()
    {
        Instantiate(spawnObjects[Random.Range(0,spawnObjects.Length)], this.transform);
        StartCoroutine(StartGame());
    }
}
