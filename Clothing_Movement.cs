using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothing_Movement : MonoBehaviour
{
    public GameObject[] spawnObjects;
    public int min = 1;
    public int max = 5;

    void Start()
    {
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
